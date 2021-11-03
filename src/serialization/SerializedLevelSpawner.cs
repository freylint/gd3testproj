using Godot;
using System;

public enum TileType : byte {
	Empty = 0,
}

public class SerializedLevelSpawner : Node
{
	private const int LevelWidth = 4;
	
	/*
	private TileType[,] tiles = new TileType[LevelWidth,LevelWidth]{
		{tE,tE,tE,tE},
		{tE,tE,tE,tE},
		{tE,tE,tE,tE},
		{tE,tE,tE,tE},
	};
	*/
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
}
