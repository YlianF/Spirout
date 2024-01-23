using Godot;
using System;

public partial class pitie : CharacterBody2D
{
	[Export]
	public int Speed { get; set; } = 650;
	
	public CharacterBody2D left;
	public CharacterBody2D right;

	public AnimatedSprite2D animatedSprite2D;
	
	public int health = 20;
	

	public override void _Ready()
	{
		var left_arm = GetNode<CharacterBody2D>("%left_arm");
		var sword = GetNode<CharacterBody2D>("%sword");

		left_arm.Hide();
		sword.Hide();
		_left_arm(sword); 
		_right_arm(left_arm); 
	}


	public override void _Process(double delta)
	{
		_move(delta);
		
		if (left != null) {
			left.GlobalPosition = GlobalPosition + new Vector2(150, 150);
			left.MoveAndSlide();
		}
		
		if (right != null) {
			right.GlobalPosition = GlobalPosition + new Vector2(-150, 150);
			right.MoveAndSlide();
		}
		
		if (Input.IsActionPressed("left_arm")) {
			var new_arm = GetNode<CharacterBody2D>("sword");
			new_arm.Hide();
			_left_arm(new_arm); 
		}
		
		if (Input.IsActionPressed("right_arm")) {
			var new_arm = GetNode<CharacterBody2D>("left_arm");
			new_arm.Hide();
			_right_arm(new_arm); 
		}
		
		if (Input.IsActionPressed("left_click")) {
			_left_attack();
		}
		
		if (Input.IsActionPressed("right_click")) {
			_right_attack();
		}
	}
	
	public void _move(double delta) {

		Vector2 velocity = Velocity;

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
			velocity.Y = direction.Y * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			velocity.Y = Mathf.MoveToward(Velocity.Y, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		
		if (velocity.X != 0)
		{
			animatedSprite2D.FlipH = velocity.X < 0;
		}
	}
	
	public void _left_arm(CharacterBody2D wpn) {
		left = wpn;
		if (right == wpn) {
			right = null;
			var velocityt = Vector2.Zero;
			velocityt.X -= left.Position.X * 2;
			left.Position += velocityt;
			left.Scale = new Vector2(1, 1);
		}
		
		left.Show();
	}
	
	public void _right_arm(CharacterBody2D wpn) {

		if (left == wpn) {
			left = null;
		}
		right = wpn;
		var velocityt = Vector2.Zero;
		velocityt.X -= right.Position.X * 2;
		right.Position += velocityt;
			
		right.Scale = new Vector2(-1, 1);
		right.Show();
	}
	
	public void _left_attack() {
		if (left != null) {
			left.Call("_attack");
		}
	}
	
	public void _right_attack() {
		if (right != null) {
			right.Call("_attack");
		}
	}
}
