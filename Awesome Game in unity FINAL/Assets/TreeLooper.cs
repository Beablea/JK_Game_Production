using UnityEngine;
using System.Collections;

public class TreeLooper : MonoBehaviour {
	//initializing variables 
	public GameObject tree1; 
	public GameObject tree2; 
	public GameObject tree3; 
	public GameObject[] trees; 
	public GameObject player; 
	public Vector3 tree_position; 
	public float time = 0.0f;
	public float minLevWidth = 1.0f; 
	public float maxLevWidth = 35.0f;

	//Calsulating the position in which the trees should spawn
	public void calculateTreePosition(){
		trees = new GameObject[] {tree1, tree2, tree3}; 
		float distance= PlayerPrefs.GetFloat("distance");
		Vector3 treeVec = new Vector3 (Random.Range (minLevWidth+distance, maxLevWidth+distance), -0.5f, 0);
		tree_position = treeVec;
		
	}
	//Spawns a random tree from a array of the three trees 
	public void spawn_tree(){
		calculateTreePosition(); 
		int spawnObjectIndex = Random.Range(0,trees.Length);
		GameObject randPrefab = trees[spawnObjectIndex];
		GameObject clonetree = (GameObject) Instantiate(randPrefab, tree_position, Quaternion.identity);
		//destroying the trees after 12 seconds in the scene
		Destroy (clonetree, 14);
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//making the trees spawn every second
		time += Time.deltaTime;
		if (time > 1.0f ){
			spawn_tree(); 
			time = 0.0f;
		}
	}
}
