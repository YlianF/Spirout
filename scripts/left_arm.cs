using Godot;
using System;

public partial class left_arm : Area2D
{
	
	PackedScene arm_attack;
	public int cooldown = 0;
	public int max_cooldown = 45;

	public override void _Ready()
	{
		arm_attack = (PackedScene) ResourceLoader.Load("res://character/arm_attack.tscn");
	}


	public override void _PhysicsProcess(double delta)
	{
		if (cooldown > 0) {
			cooldown--;
		}
		if (cooldown == 1) {
			Show();
		}
	}
	
	public void _attack() {
		if (cooldown == 0) {
			var instance = arm_attack.Instantiate();
			var scene = GetParent().GetParent();
			scene.AddChild(instance);
			Hide();
			cooldown = max_cooldown;
		}
	}
	
}
