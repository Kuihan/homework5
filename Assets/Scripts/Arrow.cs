using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
	//arrow state
	private int state = 0;
	private Vector3 pos = new Vector3 ();
	// Use this for initialization
	void Start () {
		Factory.num++;
		this.transform.Rotate (0, 0, 90);
		this.transform.position = Bow.pos;
	}
	
	// Update is called once per frame
	void Update () {
		if (MyGUI.shoot == true && state == 0)
			state = 1;
		if (this.transform.position.y < 0.35 && state == 1) {
			state = 2;
			MyGUI.shoot = false;
			pos = this.transform.position;
			Score.addscore (pos);
			Factory.addarrow ();
		}
		if (state == 1) {
			this.transform.position += new Vector3 (MyGUI.wind, 0, 0) * Time.deltaTime + new Vector3(0, -5, 0) * Time.deltaTime;
		} else if (state == 0) {
			this.transform.position = Bow.pos;
			/*
			if (MyGUI.run == 1) {
				Vector3 move;
				if (Input.GetKey (KeyCode.W)) {
					move = new Vector3 (0, 1, 0);
				} else if (Input.GetKey (KeyCode.S)) {
					move = new Vector3 (0, -1, 0);
				} else if (Input.GetKey (KeyCode.A)) {
					move = new Vector3 (-1, 0, 0);
				} else if (Input.GetKey (KeyCode.D)) {
					move = new Vector3 (1, 0, 0);
				} else {
					move = new Vector3 ();
				}
				this.transform.position += move * Time.deltaTime;
			}
			*/
		} else if (state == 2) {
			this.transform.position = pos;
		}
	}
}
