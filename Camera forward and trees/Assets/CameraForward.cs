using UnityEngine;
using System.Collections;

public class CameraForward : MonoBehaviour {

	public float forwardSpeed = 0f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		rigidbody2D.AddForce(Vector2.right * forwardSpeed);
	
	}
}
