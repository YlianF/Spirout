using Godot;
using System;
using System.Linq;
using System.Collections.Generic;
using static Godot.TileSet;

public partial class tiletest : TileMap
{
	[Export]
	public Resource closedRoom;
	
	[Export]
	public Resource hcorridor;
	
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

		GD.Print(TileSet.CellNeighbor.RightSide);
		GD.Print(this.GetNeighborCell(new Vector2I(4, 2), TileSet.CellNeighbor.RightSide));
		GD.Print(this.GetCellTileData(0, new Vector2I(5, 2)));
		
		this.generateRightCorridor();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void generateRightCorridor() {
		GD.Print("allo");
		pointer = new Vector2I(4, 3);
		if (hcorridor is hcorridor corridor) {
			var tileCount = corridor.room.Length / 2;
			for (int i = 0; i < tileCount; i++) {
				this.SetCell(0, pointer+corridor.room[i,0], 0, corridor.room[i,1], 0);
			}
		}
	}
}
