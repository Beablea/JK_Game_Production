using UnityEngine;
using System.Collections;

public class Spawn_birde : MonoBehaviour {
	public GameObject birde; 
	public Vector2 spawn_position; 
	public float timer = 0.0f; 
	Random rng = new Random(); 
	
	
	public void spawn_birde(){
		Vector2 newspawnposition = Vector2.zero; 
		Instantiate(birde, spawn_position, Quaternion.identity);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime; 
		if (timer > 2 ){
			spawn_birde(); 
			timer = 0.0f; 
	
	}
}
}