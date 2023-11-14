using Godot;
using System;

public partial class sword_attack : Node2D
{
	public int life = 15;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var parent = (Area2D) GetNode("/root/tests/Spirit");
		this.GlobalPosition = parent.GlobalPosition;
		LookAt(GetGlobalMousePosition());
		
		Position += Transform.X * 100;
		Rotation -= 0.1f;
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		Position += Transform.X * 7;
		Rotation += 0.2f;
		life--;

		if (life == 0) {
			this.QueueFree();
		}
	}
}
