using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	Vector3 movement;
	Vector3 cameraMovement;
	public Camera minimap;

	void Start() {
	}

	void Update() {

		MovePlayer();
		UpdateCamera();
		UpdateMinimap();

	}

	void MovePlayer() {
		movement = Vector3.zero;

		if ( Input.GetKeyDown( KeyCode.LeftArrow ) || Input.GetKeyDown( KeyCode.A ) )
			movement.x = -1;
		else if ( Input.GetKeyDown( KeyCode.RightArrow ) || Input.GetKeyDown( KeyCode.D ) )
			movement.x = 1;
		else if ( Input.GetKeyDown( KeyCode.UpArrow ) || Input.GetKeyDown( KeyCode.W ) )
			movement.y = 1;
		else if ( Input.GetKeyDown( KeyCode.DownArrow ) || Input.GetKeyDown( KeyCode.S ) )
			movement.y = -1;

		this.transform.position += movement;
	}

	void UpdateCamera() {
		cameraMovement = Camera.main.transform.position;

		if ( this.transform.position.x - Camera.main.transform.position.x < -2 )
			cameraMovement.x -= 1;
		else if ( this.transform.position.x - Camera.main.transform.position.x > 2 )
			cameraMovement.x += 1;
		else if ( this.transform.position.y - Camera.main.transform.position.y < -2 )
			cameraMovement.y -= 1;
		else if ( this.transform.position.y - Camera.main.transform.position.y > 2 )
			cameraMovement.y += 1;

		Camera.main.transform.position = new Vector3( cameraMovement.x, cameraMovement.y, -10 );
	}

	void UpdateMinimap() {
		minimap.transform.position = new Vector3( this.transform.position.x, this.transform.position.y, -10 );
	}
}
