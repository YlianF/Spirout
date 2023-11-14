using Godot;
using System;

public partial class arm_attack : Node2D
{
	public int life = 20;
	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var parent = (Area2D) GetNode("/root/tests/Spirit");
		this.GlobalPosition = parent.GlobalPosition;
		LookAt(GetGlobalMousePosition());
		Rotation -= 0.4f;
		Position += Transform.X * 150;
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		Position += Transform.X * 20;
		Rotation += 0.06f;
		life--;

		if (life == 0) {
			this.QueueFree();
		}
	}
	
	
}
