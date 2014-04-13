using UnityEngine;
using System.Collections;

public class EvilBird : MonoBehaviour {
	public float speed = -1.0f;
	public bool dead = false;
	float deathCooldown;
	
	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.AddForce(Vector2.right * speed);
		
		
	}
	void OnCollisionEnter2D (Collision2D other){
		if(other.gameObject.name == "Player"){
			dead = true;
			deathCooldown = 0.5f;
			Destroy(gameObject);
			
		}
		
	}
}
