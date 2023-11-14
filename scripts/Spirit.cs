using Godot;
using System;

public partial class Spirit : Area2D
{
	[Export]
	public int Speed { get; set; } = 400;
	
	public Area2D left;
	public Area2D right;

	public AnimatedSprite2D animatedSprite2D;
	
	public int health = 20;
	

	public override void _Ready()
	{
		var left_arm = GetNode<Area2D>("left_arm");
		var sword = GetNode<Area2D>("sword");
		left_arm.Hide();
		sword.Hide();
		_left_arm(sword); 
		_right_arm(left_arm); 
	}


	public override void _Process(double delta)
	{
		_move(delta);
		
		if (Input.IsActionPressed("left_arm")) {
			var new_arm = GetNode<Area2D>("sword");
			new_arm.Hide();
			_left_arm(new_arm); 
		}
		
		if (Input.IsActionPressed("right_arm")) {
			var new_arm = GetNode<Area2D>("left_arm");
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
		var velocity = Vector2.Zero;

		if (Input.IsActionPressed("right")) { velocity.X += 1; }

		if (Input.IsActionPressed("left")) { velocity.X -= 1; }

		if (Input.IsActionPressed("down")) { velocity.Y += 1; }

		if (Input.IsActionPressed("up")) { velocity.Y -= 1; }
		
		velocity = velocity.Normalized() * Speed;
		Position += velocity * (float)delta;
		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		
		if (velocity.X != 0)
		{
			animatedSprite2D.FlipH = velocity.X < 0;
		}
	}
	
	public void _left_arm(Area2D wpn) {
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
	
	public void _right_arm(Area2D wpn) {

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
