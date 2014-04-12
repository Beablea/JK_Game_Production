using UnityEngine;
using System.Collections;


public class Squirrel : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public float maxSpeed = 200f;
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

		rigidbody2D.AddForce(Vector2.right * forwardSpeed);

		if (didJump){
		rigidbody2D.AddForce( Vector2.up * maxSpeed );
			didJump=false;
		}
	
	}
	
}
