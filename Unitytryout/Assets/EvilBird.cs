using UnityEngine;
using System.Collections;

public class EvilBird : MonoBehaviour {
	public float speed = -1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.AddForce(Vector2.right * speed);
	
	}
}
