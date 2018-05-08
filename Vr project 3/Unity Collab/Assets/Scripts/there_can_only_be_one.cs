using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class there_can_only_be_one : MonoBehaviour {

	List<string> answers = new List<string>(); 
	List<string> answer_key = new List<string>{ "a", "b", "c", "a", "b", "c", "a", "b", "c", "a" };
	public bool equal = false;
	public static bool winner = false;
	public static bool loser = false;
	public GameObject WinFrame = null;
	public GameObject LoseFrame = null;
	public GameObject Quiz = null;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		check_Answers ();
		if (equal) {
			if (WinFrame.activeSelf||LoseFrame.activeSelf) {
			} 
			else {
				winner = true;
				WinFrame.SetActive (true);
				Quiz.SetActive (false);
			}
		} else if (answers.Count == 10 && !winner) {
			if (WinFrame.activeSelf || LoseFrame.activeSelf) {
			} else {
				loser = true;
				LoseFrame.SetActive (true);
			}

		}
		//Debug.Log ("-------------");
	}

	public void a1_checked (){
		if (answers.Count >= 10){
			return;
		}
		answers.Add("a");
	}

	public void a2_checked(){
		if (answers.Count >= 10){
			return;
		}
		answers.Add("b");
	}

	public void a3_checked(){
		if (answers.Count >= 10){
			return;
		}
		answers.Add("c");
	}


	public bool check_Answers(){
		equal = answers.SequenceEqual(answer_key);
		return equal;
	}



}
