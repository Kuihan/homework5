using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
	public static int score = 0;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//shoot get score
	public static void addscore(Vector3 pos){
		float d = Mathf.Sqrt (Mathf.Pow(pos.x, 2) + Mathf.Pow(pos.z, 2));
		if (d < 0.5) {
			score += 5;
		} else if (d < 1) {
			score += 4;
		} else if (d < 1.5) {
			score += 3;
		}else if(d < 2){
			score += 2;
		}else if(d < 2.5){
			score += 1;
		}
	}
}
