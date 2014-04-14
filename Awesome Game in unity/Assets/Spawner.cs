using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour{
	public GameObject birde; 
	public GameObject cam; 
	public Vector2 spawn_position; 
	public float timer = 0.0f;
	public float minLevelHeight = 0.0f; 
	public float maxLevelHeight = 7.0f; 
	public float minLevelWidth = 0.0f; 
	public float maxLevelWidth = 10.0f;  

	
	public void calculateSpawnPosition(){
//		float spawnX = Random.Range (minLevelWidth, maxLevelWidth); 
//		float spawnY = Random.Range(minLevelHeight, maxLevelHeight);
//		spawn_position = new Vector2 (spawnX, spawnY);
		cam.transform.parent = birde.transform; 
		 
	}
	public void spawn_birde(){
		calculateSpawnPosition(); 
		GameObject clone = (GameObject) Instantiate(birde, spawn_position, Quaternion.identity);
		Destroy (clone, 5); 
		
	}
	
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		
		if (timer > 1.5f ){
			spawn_birde(); 
			timer = 0.0f;
		}
	}
}
