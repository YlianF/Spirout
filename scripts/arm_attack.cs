using Godot;
using System;

public partial class arm_attack : Node2D
{
	public int life = 20;
	
	public override void _Ready()
	{
		var parent = (CharacterBody2D) GetParent();
		this.GlobalPosition = parent.GlobalPosition;
		LookAt(GetGlobalMousePosition());
		Rotation -= 0.4f;
		Position += Transform.X * 200;
	}

	public override void _PhysicsProcess(double delta)
	{
		Position += Transform.X * 20;
		Rotation += 0.04f;
		life--;

		if (life == 0) {
			this.QueueFree();
		}
	}
	
	
}
