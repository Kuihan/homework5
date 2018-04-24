using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour {
	public static Vector3 pos = new Vector3();
	// Use this for initialization
	void Start () {
		//this.transform.position = new Vector3 (0, 1, -9);
		this.transform.Rotate (0, 0, 90);
	}
	
	// Update is called once per frame
	void Update () {
		if (MyGUI.run == 1) {
			Vector3 move;
			if (Input.GetKey (KeyCode.W)) {
				move = new Vector3 (0, 0, 1);
			} else if (Input.GetKey (KeyCode.S)) {
				move = new Vector3 (0, 0, -1);
			} else if (Input.GetKey (KeyCode.A)) {
				move = new Vector3 (-1, 0, 0);
			} else if (Input.GetKey (KeyCode.D)) {
				move = new Vector3 (1, 0, 0);
			} else {
				move = new Vector3 ();
			}
			this.transform.position += move * Time.deltaTime;
			pos = this.transform.position;
		}
		pos = this.transform.position;
	}
}
