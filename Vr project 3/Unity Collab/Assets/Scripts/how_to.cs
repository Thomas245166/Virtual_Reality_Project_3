using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class how_to : MonoBehaviour {
	public GameObject canvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void howtoOpen(){
		canvas.SetActive (true);
	}
	public void howtoClose(){
		canvas.SetActive (false);
	}
}
