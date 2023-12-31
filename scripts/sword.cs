using Godot;
using System;

public partial class sword : Area2D
{
	PackedScene sword_attack;
	public int cooldown = 0;
	public int max_cooldown = 75;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		sword_attack = (PackedScene) ResourceLoader.Load("res://character/sword_attack.tscn");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
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
			var instance = sword_attack.Instantiate();
			AddChild(instance);

			cooldown = max_cooldown;
		}
	}
}
