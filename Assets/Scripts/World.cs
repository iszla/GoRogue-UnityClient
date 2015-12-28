using UnityEngine;
using System.Collections;

public class World
{

	public int width;
	public int height;
	public int[,] tiles;

	public World( int width, int height, int[,] tiles ) {
		this.width = width;
		this.height = height;
		this.tiles = tiles;
	}
}
