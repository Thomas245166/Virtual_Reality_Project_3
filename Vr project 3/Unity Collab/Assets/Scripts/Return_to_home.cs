using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return_to_home : MonoBehaviour {
	public GameObject PhoneBooth = null;
	public GameObject quiz = null;
	public static bool isHome = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isHome) {
			PhoneBooth.SetActive (false);
			if (!quiz.activeSelf) {
				if (!there_can_only_be_one.winner) {
					Debug.Log ("The Quiz wasnt active, activating. and no winner");
					quiz.SetActive (true);
				} else if (there_can_only_be_one.winner) {
					Debug.Log ("THE GAME HAS BEEN WON");
				} else if (there_can_only_be_one.loser) {
					Debug.Log("THE GAME HAS BEEN LOST");
				}

			} 
			else {
				Debug.Log ("THe quiz is active, DO NOTHING");
			}
		}
	}
}
