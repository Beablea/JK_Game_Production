﻿using UnityEngine;
using System.Collections;


public class Squirrel : EvilBird{
	 public float maxSpeed = 200f;
	//public float forwardSpeed = 0.01f;
	public bool didJump = false;
	public int CounterScore;
	public int FinalScore;
	public GameObject player; 

	public Vector3 player_position;

	// Use this for initialization
	void Start () {
		player_position = this.rigidbody.position; 

	}
	//Do graphic and Input updates here
	void Update () {
				if(Input.GetKeyDown(KeyCode.Space)) {
				didJump = true;
		}
}
	
	// physics engine update here
	void FixedUpdate () {
		if(player.transform.position.y < -2.0f || player.transform.position.y > 6.0f){
			Application.LoadLevel("endScene");
		}
		//rigidbody2D.AddForce(Vector2.right * forwardSpeed);
		
		if (didJump){
			if (player.transform.position.y<4.0f)
			{
				transform.position += new Vector3(1.0f, 1.0f, 0);
				//rigidbody2D.AddForce( Vector2.up * maxSpeed );
			}
			didJump=false;
		}

	}
	public void OnCollisionEnter2D (Collision2D other){
		if(other.gameObject.name == "GreenTree" || other.gameObject.name == "PurpleTree" || other.gameObject.name == "YellowTree" || other.gameObject.name == "YellowTree(Clone)" || other.gameObject.name == "PurpleTree(Clone)" || other.gameObject.name == "GreenTree(Clone)"){
			CounterScore++; 
			FinalScore=CounterScore; 
			
		}
	}
	public void OnGUI(){
		GUI.Box (new Rect (10, 10, 100, 20), "Score: "+ CounterScore);
	}
	
}
