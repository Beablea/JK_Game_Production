﻿using UnityEngine;
using System.Collections;

public class endScene : Squirrel { 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			didJump = true;
		if (didJump){
				Application.LoadLevel("new");
			}
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit(); 
		}

	}
	public void OnGUI(){
		GUI.Box (new Rect (100, 30, 100, 20), "High score: "+ FinalScore);
	}
}