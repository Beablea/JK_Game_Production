using UnityEngine;
using System.Collections;

public class TreeLooper : MonoBehaviour {
	public GameObject tree1; 
	public GameObject tree2; 
	public GameObject tree3; 
	public GameObject player; 
	public Vector3 tree_position1; 
	public Vector3 tree_position2; 
	public Vector3 tree_position3; 
	public float time = 0.0f;
	public float minLevWidth = 1.0f; 
	public float maxLevWidth = 10.0f;  
	
	
	public void calculateTreePosition(){
		Vector3 treeVec1 = new Vector3 (Random.Range (minLevWidth+player.transform.position.x, maxLevWidth), 0, 0);
		tree_position1 = treeVec1;
		Vector3 treeVec2 = new Vector3 (Random.Range (minLevWidth+player.transform.position.x, maxLevWidth), 0, 0);
		tree_position2 = treeVec2;
		Vector3 treeVec3 = new Vector3 (Random.Range (minLevWidth+player.transform.position.x, maxLevWidth), 0, 0);
		tree_position3 = treeVec3;
		
	}
	public void spawn_tree(){
		calculateTreePosition(); 
		GameObject clonetree1 = (GameObject) Instantiate(tree1, tree_position1, Quaternion.identity);
		Destroy (clonetree1, 7);
		GameObject clonetree2 = (GameObject) Instantiate(tree2, tree_position2, Quaternion.identity);
		Destroy (clonetree2, 7);
		GameObject clonetree3 = (GameObject) Instantiate(tree3, tree_position3, Quaternion.identity);
		Destroy (clonetree3, 7);
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 1.5f ){
			spawn_tree(); 
			time = 0.0f;
		}
	}
}
