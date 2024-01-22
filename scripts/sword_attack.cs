using Godot;
using System;

public partial class sword_attack : Node2D
{
	public int life = 12;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var parent = (CharacterBody2D) GetParent();
		this.GlobalPosition = parent.GlobalPosition;
		LookAt(GetGlobalMousePosition());
		
		Position += Transform.X * 150;
		Rotation -= 0.1f;
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		Position += Transform.X * 15;
		Rotation += 0.3f;
		life--;

		if (life == 0) {
			this.QueueFree();
		}
	}
}
