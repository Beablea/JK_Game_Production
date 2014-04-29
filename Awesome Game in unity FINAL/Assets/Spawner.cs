using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour{
	//Initilizing all the variables for the spawncode
	public GameObject birde; 
	public GameObject player; 
	public Vector3 spawn_position; 
	public float timer = 0.0f;
	public float minLevelHeight = 0.8f; 
	public float maxLevelHeight = 1.8f; 
	public float minLevelWidth = 15.0f; 
	public float maxLevelWidth = 30.0f;  

	// Caculating the ramdom spawning positions for the birds by the use of Vector3
	public void calculateSpawnPosition(){
//		Vector3 newVec = new Vector3 (Random.Range (minLevelWidth+player.transform.position.x, maxLevelWidth), Random.Range (minLevelHeight+player.transform.position.y, maxLevelHeight), 0);
		float distance= PlayerPrefs.GetFloat("distance"); 
		Vector3 newVec = new Vector3 (Random.Range (minLevelWidth+distance, maxLevelWidth+distance), Random.Range (minLevelHeight, maxLevelHeight), 0);

		spawn_position = newVec;
		 
	}
	//Function to make the birds spawn
	public void spawn_birde(){
		calculateSpawnPosition(); 
		GameObject clone = (GameObject) Instantiate(birde, spawn_position, Quaternion.identity);
		//Destroying the clone after 5 seconds
		Destroy (clone, 5); 
		
	}
	
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		// A timer that helps determine the number of seconds between each spawn
		timer += Time.deltaTime;
		
		if (timer > 1.0f ){
			spawn_birde(); 
			timer = 0.0f;
		}
	}
}
