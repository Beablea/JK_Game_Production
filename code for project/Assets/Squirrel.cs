using UnityEngine;
using System.Collections;


public class Squirrel : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public Vector3 jumpVelocity;
	private float maxSpeed = 5f;
	public float forwardSpeed = 1f;

	bool didJump = false;

	// Use this for initialization
	void Start () {
	
	}
	//Do graphic and Input updates here
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space)) {
			didJump = true;
		}
	}

	// physics engine update here
	void FixedUpdate () {
		velocity.x = forwardSpeed;
		velocity += gravity*Time.deltaTime;

		//the jumping physics
		if (didJump == true) {
			didJump = false;
			if(velocity.y < 0){
				velocity.y=0;}
			velocity += jumpVelocity;
		}

		velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

		transform.position += velocity *Time.deltaTime;
	}
}
