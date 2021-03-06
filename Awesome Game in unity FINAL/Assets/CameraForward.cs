﻿using UnityEngine;
using System.Collections;

public class CameraForward : MonoBehaviour { 	Transform player;
	float offsetX; 
	
	// Use this for initialization
 public void Start () {
	 GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		
		if(player_go == null) {
			return;
		}
		
		player = player_go.transform;
		
		offsetX = transform.position.x - player.position.x;
	}
	
	// Update is called once per frame
	public void Update () {
		//follow the transform position of the player is it is moving
		if(player != null) {
			Vector2 pos = transform.position;
			pos.x = player.position.x + offsetX;
			transform.position = pos;
		}
		
	}
}
