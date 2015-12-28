using UnityEngine;
using System.Collections;
using SimpleJSON;

[RequireComponent( typeof(LoadWorld) )]
[RequireComponent( typeof(Assets) )]
public class WorldController : MonoBehaviour
{
	bool worldBuilt;

	void Start() {
		worldBuilt = false;
	}

	void Update() {
		if ( LoadWorld.worldData == null )
			return;

		if ( !worldBuilt )
			BuildWorld();
	}

	void BuildWorld() {
		Debug.Log( "Building..." );

		for ( int x = 0; x < LoadWorld.worldData.width; x++ ) {
			for ( int y = 0; y < LoadWorld.worldData.height; y++ ) {
				GameObject tile = new GameObject();

				tile.name = "Tile_" + x + "_" + y;
				tile.transform.position = new Vector3( x, y, 0 );
				tile.transform.SetParent( this.transform, true );
				tile.AddComponent<SpriteRenderer>().sprite = Assets.tileSprites[ (TileType)LoadWorld.worldData.tiles[ x, y ] ];

				if ( LoadWorld.worldData.tiles[ x, y ] == 1 )
					tile.AddComponent<BoxCollider2D>();
			}
		}

		worldBuilt = true;
		Debug.Log( "Building finished" );
	}
}
