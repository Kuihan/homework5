using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour {
	private static Factory fac;
	public static Bow bow;
	public static Arrow arrow;
	public static int num;
	//construct
	private Factory(){

	}

	// Use this for initialization
	void Start () {
		num = 0;
		Instantiate (Resources.Load ("Prefabs/Target"), new Vector3 (0, 0, 0), Quaternion.identity);
		bow = Instantiate (Resources.Load ("Prefabs/Bow"), new Vector3 (0, 8, 0), Quaternion.identity) as Bow;
		addarrow ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static Factory get(){
		if (fac == null) {
			fac = new Factory ();
		}
		return fac;
	}

	public static void addarrow(){
		arrow = Instantiate (Resources.Load ("Prefabs/Arrow"), new Vector3 (0, 8, 0), Quaternion.identity) as Arrow;
	}
}
