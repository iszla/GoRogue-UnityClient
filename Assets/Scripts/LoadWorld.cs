using UnityEngine;
using SimpleJSON;
using System.Collections;

public class LoadWorld : MonoBehaviour
{

	string url = "http://localhost:3322/island/full";
	WWW worldUrl;
	JSONNode worldJson;
	int[,] tiles;
	int lx, ly;
	public static World worldData;

	IEnumerator Start() {
		worldUrl = new WWW( url );

		yield return worldUrl;
		if ( worldUrl.error == null ) {
			worldJson = JSONNode.Parse( worldUrl.text );

			tiles = new int[worldJson[ "width" ].AsInt, worldJson[ "height" ].AsInt];

			for ( int i = 0; i < worldJson[ "layers" ][ 0 ][ "data" ].Count; i++ ) {	
				lx = i % worldJson[ "width" ].AsInt;
				ly = i / worldJson[ "width" ].AsInt;

				tiles[ lx, ly ] = worldJson[ "layers" ][ 0 ][ "data" ][ i ].AsInt;
			}

			worldData = new World( worldJson[ "width" ].AsInt, worldJson[ "height" ].AsInt, tiles );
		}
	}
}
