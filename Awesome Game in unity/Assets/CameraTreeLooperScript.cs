using UnityEngine;
using System.Collections;

public class CameraTreeLooperScript : MonoBehaviour {

	//
	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Triggered: " + collider.name);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
