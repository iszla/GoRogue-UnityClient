using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	Vector3 playerMovement;

	// Use this for initialization
	void Start() {
		playerMovement = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update() {
		playerMovement = new Vector3( Input.GetAxisRaw( "Horizontal" ), Input.GetAxisRaw( "Vertical" ), 0 );

		this.transform.position += playerMovement;
		Camera.main.transform.position = new Vector3( this.transform.position.x, this.transform.position.y, -10 );
	}
}
