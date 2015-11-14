﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Possible Player Events

	public delegate void SpawnEvent(ref Vector2 currentCell);
	public static event SpawnEvent onSpawn;
	public delegate void DieEvent();
	public static event DieEvent onDeath;
	public delegate void MoveEvent();
	public static event MoveEvent onMove;
	public delegate void KeyEvent();
	public delegate void WinEvent();
	public static event WinEvent onWinEvent;

	private int[,] map;
	private int[] neighbours = new int[4];
	private Vector2 currentCell;

	// might have to change the script execution error for this
	// Use this for initialization
	void Start () {
	
		// Grab the Map Object from the Player
		GameObject mapObject = GameObject.Find ("Map");
		map = mapObject.GetComponent<MapGeneration>().Map; // grab the refrence from the map generation
		// interestingly, we might also want to guarantee that this always executes in a certain order. 
		onSpawn(ref currentCell);
		Debug.Log("Current Cell: " + currentCell.x + "," + currentCell.y);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.A))

		if(Input.GetKey(KeyCode.D))
			Debug.Log("Pressed D");
		if(Input.GetKey (KeyCode.S))
			Debug.Log ("Pressed S");
		if(Input.GetKey(KeyCode.W))
			Debug.Log("Pressed W");

	}
}
