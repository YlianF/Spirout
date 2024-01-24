using Godot;
using System;

public partial class hcorridor : Resource
{
	
	public Vector2I[,] hallway { get; set; }
	public Vector2I[,] opening { get; set; }
	public Vector2I[,] ending { get; set; }
	
	public int height { get; set; }
	
	public Vector2I[,] _OPENING = {

		{ new Vector2I(-1, 1), new Vector2I(19, 0) },
		{ new Vector2I(-1, 2), new Vector2I(15, 0) },
		{ new Vector2I(-1, 3), new Vector2I(15, 0) },
		
		{ new Vector2I(0, 0), new Vector2I(22, 0) },
		{ new Vector2I(0, 1), new Vector2I(20, 0) },
		{ new Vector2I(0, 2), new Vector2I(15, 0) },
		{ new Vector2I(0, 3), new Vector2I(18, 0) },
	};
	public Vector2I[,] _HALLWAY = {
		{ new Vector2I(0, 0), new Vector2I(4, 0) },
		{ new Vector2I(0, 1), new Vector2I(21, 0) },
		{ new Vector2I(0, 2), new Vector2I(15, 0) },
		{ new Vector2I(0, 3), new Vector2I(23, 0) },
	};
	public Vector2I[,] _ENDING = {
		{ new Vector2I(1, 0), new Vector2I(24, 0) },
		{ new Vector2I(1, 1), new Vector2I(27, 0) },
		{ new Vector2I(1, 2), new Vector2I(15, 0) },
		{ new Vector2I(1, 3), new Vector2I(29, 0) },
	};
	
	
	public hcorridor() {
		this.height = 4;
		this.opening = _OPENING;
		this.hallway = _HALLWAY;
		this.ending = _ENDING;
	}
	
}
