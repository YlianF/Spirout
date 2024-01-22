using Godot;
using System;
using System.Linq;
using System.Collections.Generic;

public partial class tiletest : TileMap
{
	[Export]
	public Resource closedRoom;
	
	private Vector2I pointer = new Vector2I(0, 0);
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if (closedRoom is closed room) {
			var tileCount = room.room.Length / 2;
			for (int i = 0; i < tileCount; i++) {
				this.SetCell(0, room.room[i,0]-pointer, 0, room.room[i,1], 0);
			}
		}
		// this.SetCell(0, new Vector2I(4, 0), 0, new Vector2I(5, 0), 0);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
