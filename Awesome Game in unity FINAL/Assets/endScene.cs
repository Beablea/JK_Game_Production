using UnityEngine;
using System.Collections;

public class endScene : Squirrel { 
	public int FinalScore; 
	// Use this for initialization
	void Start () {
		//getting the score from the squirrel class
		FinalScore = PlayerPrefs.GetInt ("CounterScore"); 
	
	}
	
	// Update is called once per frame
	void Update () {
		//load the game is the space bar is pressed
		if(Input.GetKeyDown(KeyCode.Space)){
			didJump = true;
		if (didJump){
				Application.LoadLevel("new");
			}
		}
		//exits the application is esc is pressed
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit(); 
		}

	}
	public void OnGUI(){
		//printing final score
		GUI.Box (new Rect (370, 350, 200, 20), "High score: "+ FinalScore);
	}
}
