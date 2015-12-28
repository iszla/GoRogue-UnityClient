using UnityEngine;
using System.Collections.Generic;

public enum TileType
{
	Unused,
	DeepWater,
	ShallowWater,
	Beach,
	Grass,
	Land
}

public class Assets : MonoBehaviour
{
	public static Dictionary<TileType, Sprite> tileSprites;
	public Sprite DeepWater;
	public Sprite ShallowWater;
	public Sprite Beach;
	public Sprite Grass;
	public Sprite Land;

	void Start() {
		tileSprites = new Dictionary<TileType, Sprite>();

		tileSprites.Add( TileType.DeepWater, DeepWater );
		tileSprites.Add( TileType.ShallowWater, ShallowWater );
		tileSprites.Add( TileType.Beach, Beach );
		tileSprites.Add( TileType.Grass, Grass );
		tileSprites.Add( TileType.Land, Land );
	}
}