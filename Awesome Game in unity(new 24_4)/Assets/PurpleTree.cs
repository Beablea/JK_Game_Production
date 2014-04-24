using UnityEngine;
using System.Collections;

public class PurpleTree : MonoBehaviour {
	public int CountCollisions;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
		void OnCollisionEnter2D(Collision2D other){
			if(other.gameObject.name == "PlayerSquirrel"){
				CountCollisions++;
				Destroy (gameObject); 
			}
		}
		void OnGUI(){
			GUI.Box(new Rect(10,10,100,20), "Score:" + CountCollisions);
		}

}
