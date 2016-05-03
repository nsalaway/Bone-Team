using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour {

	public void LoadIntro(){
		SceneManager.LoadScene (1);
	}

	public void LoadCredits(){
		SceneManager.LoadScene (2);
	}

	public void LoadGame(){
		SceneManager.LoadScene (3);
	}

}
