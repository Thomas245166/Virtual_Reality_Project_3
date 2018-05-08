using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour {
	public GameObject canvas;
	float TmStart;
	float TmLen=12f;

	// Use this for initialization
	void Start () {
		TmStart=Time.time;
		//Debug.Log ("THIS IS THE START");
		canvas.SetActive(false);
		//Debug.Log ("THIS IS THE START");
	}

	// Update is called once per frame
	void Update () {
		if(Time.time>TmStart + TmLen) 
		{
		//	Debug.Log ("THIS IS NOW PAST 3 SECONDS");
			canvas.SetActive(true);
		}
	}
}
