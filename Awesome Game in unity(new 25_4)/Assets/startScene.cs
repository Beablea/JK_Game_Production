using UnityEngine;
using System.Collections;

public class startScene : Squirrel {

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
	}
}