using UnityEngine;
using System.Collections;

public class Spawn_birde : MonoBehaviour {
	public GameObject birde; 
	public Vector2 spawn_position; 
	public float timer = 0.0f; 
	public int minLevelHeight = 0; 
	public int maxLevelHeight = 10; 
	public int minLevelWidth = 0; 
	public int maxLevelWidth = 10; 

	public void calculateSpawnPosition(){
		int spawnX = Random.Range (minLevelWidth, maxLevelWidth); 
		int spawnY = Random.Range(minLevelHeight, maxLevelHeight); 
		spawn_position = new Vector2 (spawnX, spawnY);
	}
	public void spawn_birde(){
		calculateSpawnPosition(); 
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