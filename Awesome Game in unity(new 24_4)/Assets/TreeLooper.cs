using UnityEngine;
using System.Collections;

public class TreeLooper : MonoBehaviour {
	public GameObject tree1; 
	public GameObject tree2; 
	public GameObject tree3; 
	public GameObject[] trees; 
	public GameObject player; 
	public Vector3 tree_position; 
	public float time = 0.0f;
	public float minLevWidth = 1.0f; 
	public float maxLevWidth = 10.0f;
	public int CountCollisions; 

	public void calculateTreePosition(){
		trees = new GameObject[] {tree1, tree2, tree3}; 
		Vector3 treeVec = new Vector3 (Random.Range (minLevWidth+player.transform.position.x, maxLevWidth), 0, 0);
		tree_position = treeVec;
		
	}
	public void spawn_tree(){
		calculateTreePosition(); 
		int spawnObjectIndex = Random.Range(0,trees.Length);
		GameObject randPrefab = trees[spawnObjectIndex];
		GameObject clonetree = (GameObject) Instantiate(randPrefab, tree_position, Quaternion.identity);
		Destroy (clonetree, 20);
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		time += Time.deltaTime;
		if (time > 1.5f ){
			spawn_tree(); 
			time = 0.0f;
		}
	}

		void OnTriggerEnter2D(Collider2D other){
			if(other.tag == "Player")
			CountCollisions++;
		}
		void OnGUI(){
		GUI.Box(new Rect(10,10,100,20), "Score:" + CountCollisions);
}
}