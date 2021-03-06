﻿using UnityEngine;
using System.Collections;
/*
 * start the game and create the game controller
 */
public class Starter : MonoBehaviour {


	private GameObject musicObj;
	public GameObject gameManager;

	void Awake () {
		musicObj = GameObject.FindGameObjectWithTag ("Music");
	}
	
	// Update is called once per frame
	void Update () {
		if (!musicObj.GetComponent<AudioSource> ().isPlaying) {
			musicObj.GetComponent<BackgroundMusic>().GameStart();
			gameManager.GetComponent<GameController>().enabled = true;
			Destroy(gameObject);
		}

	}
}
