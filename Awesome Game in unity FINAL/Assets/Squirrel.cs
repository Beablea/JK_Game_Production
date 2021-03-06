﻿using UnityEngine;
using System.Collections;


public class Squirrel : EvilBird{
	 public float maxSpeed = 200f;
	public float maxtSpeed = 1.0f;
	public bool didJump = false;
	public int CounterScore;
	public GameObject player; 
	public float distance;
	
	// Use this for initialization
	void Start () {
		distance=0.0f;
	}
	//Do graphic and Input updates here
	void Update () {
				if(Input.GetKeyDown(KeyCode.Space)) {
				didJump = true;
		}
		//update the squirrel position each frame, making it move
		transform.position += new Vector3(0.03f, 0, 0);
		distance+=0.03f;
		PlayerPrefs.SetFloat("distance", distance); 
}
	
	// physics engine update here
	void FixedUpdate () {
		//makes it impossible to go beyond the boundries without dying
		if(player.transform.position.y < -2.0f || player.transform.position.y > 6.0f){
			Application.LoadLevel("endScene");
		}

		
		if (didJump){
			if (this.transform.position.y<4.0f)
			{
				//add force in upwards direction when space is pressed
				rigidbody2D.AddForce(Vector2.up * maxSpeed );
				
			}
			didJump=false;
		}

	}
	public void OnCollisionEnter2D (Collision2D other){
		//sees is there is collision with trees and adding point to a variable
		if(other.gameObject.name == "GreenTree" || other.gameObject.name == "PurpleTree" || other.gameObject.name == "YellowTree" || other.gameObject.name == "YellowTree(Clone)" || other.gameObject.name == "PurpleTree(Clone)" || other.gameObject.name == "GreenTree(Clone)"){
			CounterScore++;
			int Score = this.CounterScore;
			PlayerPrefs.SetInt("CounterScore", Score);
		}
	}
	public void OnGUI(){
		//printing the current score
		GUI.Box (new Rect (10, 10, 100, 20), "Score: "+ CounterScore);
	}
	
}
