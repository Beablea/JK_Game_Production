using UnityEngine;
using System.Collections;

public class EvilBird : MonoBehaviour {
	// Initilizing the variables 
	public float speed = -1.0f;
	public bool dead = false;
	public float deathCooldown;

	
	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// Making the bird move with the speed
		rigidbody2D.AddForce(Vector2.right * speed);
		
		
	}
	// If the bird collides with the squirrel then the game will end and the gameover "endscene" will be played
	void OnCollisionEnter2D (Collision2D other){
		if(other.gameObject.name == "PlayerSquirrel"){
			Application.LoadLevel("endScene");
			Destroy(gameObject);
			
		}
		
	}
}
