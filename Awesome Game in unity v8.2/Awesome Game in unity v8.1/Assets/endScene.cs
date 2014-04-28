using UnityEngine;
using System.Collections;

public class endScene : Squirrel { 
	public int FinalScore; 

	// Use this for initialization
	void Start () {
		FinalScore = PlayerPrefs.GetInt ("CounterScore"); 
	
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
		GUI.Box (new Rect (450, 350, 200, 20), "High score: "+ FinalScore);
	}
}
