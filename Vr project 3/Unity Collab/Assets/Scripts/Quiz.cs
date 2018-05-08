using UnityEngine;
using System.Collections;

public  class Quiz : MonoBehaviour
{

	public int current_page = 0;
	public GameObject[] questions = new GameObject[10];
	public GameObject[] question_one = new GameObject[10];
	public GameObject[] question_two = new GameObject[10];
	public GameObject[] question_three = new GameObject[10];



	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}


	public void page_right(){
		if (current_page != 9) {
			
			current_page = current_page + 1;

			questions [current_page].SetActive (true);
			question_one [current_page].SetActive(true);
			question_two [current_page].SetActive(true);
			question_three [current_page].SetActive(true);
			for (int i = 0; i < current_page; i++) {
				questions [i].SetActive (false);
				question_one [i].SetActive(false);
				question_two [i].SetActive(false);
				question_three [i].SetActive(false);
			}

			for (int i = current_page + 1; i < 10; i++) {
				questions [i].SetActive (false);
				question_one [i].SetActive(false);
				question_two [i].SetActive(false);
				question_three [i].SetActive(false);
			}
		} 
		else if (current_page == 9) {
			there_can_only_be_one quiz = new there_can_only_be_one();
			bool is_correct = quiz.check_Answers ();
			if (is_correct) {
				questions [4].SetActive (true);
				questions [6].SetActive (true);
				questions [2].SetActive (true);
				questions [3].SetActive (true);
				questions [8].SetActive (true);

			}

		}

	}
}
