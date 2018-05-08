using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {
	public Transform endCamMarker = null;
	public Transform outCamMarker = null;
	public Transform inCamMarker = null;
	public int isMoveOut = 0;
	public int isMoveIn=0;
	public int isMove = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isMove == 1) {
			transform.position = Vector3.Lerp (transform.position, endCamMarker.position, Time.deltaTime);
		}
		if (isMoveIn == 1) {
			transform.position = Vector3.Lerp (transform.position, inCamMarker.position, Time.deltaTime);
		}
		if (isMoveOut == 1) {
			transform.position = Vector3.Lerp (transform.position, outCamMarker.position, Time.deltaTime);
		}
	}
	public void move(){
		isMove = 1;
	}

	public void moveOut(){
		isMoveOut = 1;
		isMoveIn = 0;
		isMove = 0;
	}

	public void moveIn(){
		isMoveIn = 1;
		isMoveOut = 0;
		isMove = 0;
	}

}

