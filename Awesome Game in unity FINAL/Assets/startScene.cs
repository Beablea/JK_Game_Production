﻿using UnityEngine;
using System.Collections;

public class startScene : Squirrel {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//loads the game if space is pressed
		if(Input.GetKeyDown(KeyCode.Space)){
			didJump = true;
			if (didJump){
				Application.LoadLevel("new");

	}
}
}
	 void OnGUI(){
			GUI.Box (new Rect (1, 1, 1, 1), " ");
		}
}
