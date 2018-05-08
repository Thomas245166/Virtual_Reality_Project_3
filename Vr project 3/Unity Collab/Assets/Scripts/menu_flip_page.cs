using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_flip_page : MonoBehaviour {
	public GameObject page_one = null;
	public GameObject page_two = null;
	public GameObject page_three = null;
	public GameObject page_four = null;

	int current_page = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void page_right(){
		if (current_page == 1) {
			page_one.SetActive (false);
			page_two.SetActive (true);
			page_three.SetActive (false);
			page_four.SetActive (false);
			current_page = 2;
		} else if (current_page == 2) {
			page_one.SetActive (false);
			page_two.SetActive (false);
			page_three.SetActive (true);
			page_four.SetActive (false);
			current_page = 3;
		} else if (current_page == 3) {
			page_one.SetActive (false);
			page_two.SetActive (false);
			page_three.SetActive (false);
			page_four.SetActive (true);
			current_page = 4;
		} else if (current_page == 4) {
			page_one.SetActive (true);
			page_two.SetActive (false);
			page_three.SetActive (false);
			page_four.SetActive (false);
			current_page = 1;
		}
	}

	public void page_left(){
		if (current_page == 1) {
			page_one.SetActive (false);
			page_two.SetActive (false);
			page_three.SetActive (false);
			page_four.SetActive (true);
			current_page = 4;
		} else if (current_page == 2) {
			page_one.SetActive (true);
			page_two.SetActive (false);
			page_three.SetActive (false);
			page_four.SetActive (false);
			current_page = 1;
		} else if (current_page == 3) {
			page_one.SetActive (false);
			page_two.SetActive (true);
			page_three.SetActive (false);
			page_four.SetActive (false);
			current_page = 2;
		} else if (current_page == 4) {
			page_one.SetActive (false);
			page_two.SetActive (false);
			page_three.SetActive (true);
			page_four.SetActive (false);
			current_page = 3;
		}
	}

}
