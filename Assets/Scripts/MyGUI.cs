using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyGUI : MonoBehaviour {
	float width, height;
	//game state
	public static int run = 0;
	public static Boolean shoot = false;
	public int setwind = 0;
	public static int wind = 0;
	// Use this for initialization
	void Start () {
		width = Screen.width / 12;
		height = Screen.height / 12;
	}
	
	// Update is called once per frame
	void Update () {
		wind = setwind;
		/*
		if (shoot == true)
			print ("ok");
		else
			print ("nok");
			*/
	}

	float castw(float scale)
	{
		return (Screen.width - width) / scale;
	}

	float casth(float scale)
	{
		return (Screen.height - height) / scale;
	}

	void OnGUI(){
		GUI.Box (new Rect (0, 0, width, height), "Your Score:" + Score.score);
		if (run == 0) {
			if (GUI.Button (new Rect (castw (2f), casth (2f), width, height), "Start")) {
				print ("Start");
				++run;
			}
		} else if (run == 1) {
			GUI.Box (new Rect (castw (1f), 0, width, height), "Wind:\n" + ((wind < 0)? "←" : "→") + Mathf.Abs(wind));
			if (GUI.Button (new Rect (castw (2f), 0, width, height), "Shoot")) {
				shoot = true;
				print ("Shoot");
			}
		} else {
			GUI.Label(new Rect (castw (2f), casth (4f), width, height), "Gameover!");
			if (GUI.Button (new Rect (castw (2f), casth (2f), width, height), "ReStart")) {
				run = 0;
				//reset
			}
		}
	}
}
