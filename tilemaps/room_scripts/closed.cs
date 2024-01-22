using Godot;
using System;
using System.Collections.Generic;

public partial class closed : Resource
{
	public Vector2I[,] room { get; set; }
	
	public Vector2I[,] _ROOM = {
		{ new Vector2I(-1, 0), new Vector2I(3, 0) },
		{ new Vector2I(0, 0), new Vector2I(4, 0) },
		{ new Vector2I(1, 0), new Vector2I(4, 0) },
		{ new Vector2I(2, 0), new Vector2I(4, 0) },
		{ new Vector2I(3, 0), new Vector2I(4, 0) },
		{ new Vector2I(4, 0), new Vector2I(7, 0) },
		
		{ new Vector2I(-1, 1), new Vector2I(2, 0) },
		{ new Vector2I(0, 1), new Vector2I(1, 0) },
		{ new Vector2I(1, 1), new Vector2I(1, 0) },
		{ new Vector2I(2, 1), new Vector2I(1, 0) },
		{ new Vector2I(3, 1), new Vector2I(1, 0) },
		{ new Vector2I(4, 1), new Vector2I(8, 0) },
		
		{ new Vector2I(-1, 2), new Vector2I(2, 0) },
		{ new Vector2I(0, 2), new Vector2I(1, 0) },
		{ new Vector2I(1, 2), new Vector2I(1, 0) },
		{ new Vector2I(2, 2), new Vector2I(1, 0) },
		{ new Vector2I(3, 2), new Vector2I(1, 0) },
		{ new Vector2I(4, 2), new Vector2I(8, 0) },
		
		{ new Vector2I(-1, 3), new Vector2I(2, 0) },
		{ new Vector2I(0, 3), new Vector2I(1, 0) },
		{ new Vector2I(1, 3), new Vector2I(1, 0) },
		{ new Vector2I(2, 3), new Vector2I(1, 0) },
		{ new Vector2I(3, 3), new Vector2I(1, 0) },
		{ new Vector2I(4, 3), new Vector2I(8, 0) },
		
		{ new Vector2I(-1, 4), new Vector2I(2, 0) },
		{ new Vector2I(0, 4), new Vector2I(1, 0) },
		{ new Vector2I(1, 4), new Vector2I(1, 0) },
		{ new Vector2I(2, 4), new Vector2I(1, 0) },
		{ new Vector2I(3, 4), new Vector2I(1, 0) },
		{ new Vector2I(4, 4), new Vector2I(8, 0) },
		
		{ new Vector2I(-1, 5), new Vector2I(6, 0) },
		{ new Vector2I(0, 5), new Vector2I(4, 0) },
		{ new Vector2I(1, 5), new Vector2I(4, 0) },
		{ new Vector2I(2, 5), new Vector2I(4, 0) },
		{ new Vector2I(3, 5), new Vector2I(4, 0) },
		{ new Vector2I(4, 5), new Vector2I(9, 0) },
	};
	
	public closed() {
		this.room = _ROOM;
	}
}
