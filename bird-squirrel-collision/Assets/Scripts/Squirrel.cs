using UnityEngine;
using System.Collections;



public class Squirrel : EvilBird{


	public float maxSpeed = 200f;
	public float forwardSpeed = 1f;
	bool didJump = false;


	// Use this for initialization
	void Start () {

	}
	//Do graphic and Input updates here
	void Update () {
		if(dead) {
			deathCooldown -= Time.deltaTime;
			
			if(deathCooldown <= 0) {
				if(Input.GetKeyDown(KeyCode.Space)) {
					Application.LoadLevel( Application.loadedLevel );
				}
			}
		}
		else {
			if(Input.GetKeyDown(KeyCode.Space)) {
				didJump = true;
			}
		}
	}

	// physics engine update here
	void FixedUpdate () {
		if(dead){
			return;
		}
		rigidbody2D.AddForce(Vector2.right * forwardSpeed);

		if (didJump){
			rigidbody2D.AddForce( Vector2.up * maxSpeed );
			didJump=false;
		}
	
	}

}
