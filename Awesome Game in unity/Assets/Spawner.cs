using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour{
	public GameObject birde; 
	public GameObject player; 
	public Vector3 spawn_position; 
	public float timer = 0.0f;
	public float minLevelHeight = 0.0f; 
	public float maxLevelHeight = 4.0f; 
	public float minLevelWidth = 0.0f; 
	public float maxLevelWidth = 10.0f;  

	
	public void calculateSpawnPosition(){
		Vector3 newVec = new Vector3 (Random.Range (minLevelWidth+player.transform.position.x, maxLevelWidth), Random.Range (minLevelHeight+player.transform.position.y, maxLevelHeight), 0);
		spawn_position = newVec;
		 
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
