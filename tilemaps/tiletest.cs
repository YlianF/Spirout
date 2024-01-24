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
	private int hcorridorTileCount;
	
	private Vector2I pointer = new Vector2I(0, 0);
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if (hcorridor is hcorridor corridor) {
			hcorridorTileCount = corridor.height;
		}

		Random rnd = new Random();
		if (closedRoom is closed room) {
			var roomTileCount = room.room.Length / 2;
			for (int i = 0; i < roomTileCount; i++) {
				this.SetCell(0, pointer+room.room[i,0], 0, room.room[i,1], 0);
			}
			var rightWallTileCount = room.rightWall.Length / 2;
			for (int i = 0; i < rightWallTileCount; i++) {
				this.SetCell(0, pointer+room.rightWall[i,0], 0, room.rightWall[i,1], 0);
			}
			int nextWall = rnd.Next(hcorridorTileCount, rightWallTileCount) - hcorridorTileCount;
			
			GD.Print(nextWall);
			GD.Print(hcorridorTileCount);
			GD.Print(rightWallTileCount);

			pointer = room.rightWall[nextWall,0];
		}
		
		this.generateRightCorridor();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void generateRightCorridor() {

		if (hcorridor is hcorridor corridor) {
			Random rnd = new Random();
			int wallLength = rnd.Next(4, 10);
			
			// on génère le début du mur
			var openingTileCount = corridor.opening.Length / 2;
			for (int i = 0; i < openingTileCount; i++) {
				this.SetCell(0, pointer+corridor.opening[i,0], 0, corridor.opening[i,1], 0);
			}
			
			// longueur aléatoire
			var hallwayTileCount = corridor.hallway.Length / 2;
			for (int i = 0; i < wallLength; i++) {
				pointer += new Vector2I(1, 0);
				for (int j = 0; j < hallwayTileCount; j++) {
					this.SetCell(0, pointer+corridor.hallway[j,0], 0, corridor.hallway[j,1], 0);
				}
			}
			
			// fin du mur
			var endingTileCount = corridor.ending.Length / 2;
			for (int i = 0; i < endingTileCount; i++) {
				this.SetCell(0, pointer+corridor.ending[i,0], 0, corridor.ending[i,1], 0);
			}
		}
	}
}
