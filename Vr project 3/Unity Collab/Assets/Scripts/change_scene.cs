using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour {
	static List<string> visited = new List<string>();
	List<string> all_places = new List<string>{"Rome","France","Titanic"};
	public GameObject home_button = null;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("-------------");
		//visited.ForEach(i => Debug.Log(i));
		if (all_places.All(i=>visited.Contains(i))) 
		{
			//Debug.Log ("YOU HAVE VISITED ALL PLACES");
			home_button.SetActive (true);
			Return_to_home.isHome = true;
		};
		//Debug.Log ("-------------");
	}
	public void ToFrance() {
		visited.Add ("France");
		SceneManager.LoadScene("Napoleon",LoadSceneMode.Single);
		//Application.LoadLevel("Napoleon");
	}
	public void ToTitanic() {
		visited.Add ("Titanic");	
		SceneManager.LoadScene("Titanic",LoadSceneMode.Single);
		//Application.LoadLevel("Napoleon");
	}
	public void ToRome() {	
		visited.Add ("Rome");
		SceneManager.LoadScene("Caesar",LoadSceneMode.Single);
		//Application.LoadLevel("Napoleon");
	}
	public void ToTTU() {	
		SceneManager.LoadScene("TTUSkybox",LoadSceneMode.Single);
		//Application.LoadLevel("Napoleon");
	}
}

