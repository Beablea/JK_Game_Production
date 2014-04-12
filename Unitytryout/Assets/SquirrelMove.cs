using UnityEngine;
using System.Collections;

public class SquirrelMove : MonoBehaviour {
	public float speed = 1.0f; 
	Vector3 velocity = Vector3.zero;
	public Vector3 gravity; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.AddForce(Vector2.right * speed); 
		//velocity += gravity; 
		//transform.position += velocity * Time.deltaTime; 
	}
}
