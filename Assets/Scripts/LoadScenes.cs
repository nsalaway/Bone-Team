using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour {

	public AudioSource soundManager;
	public AudioClip yesSound1;
	public AudioClip moreSound;
	public AudioClip yesSound2;
	public GameObject playButt;
	public GameObject easyButt;
	public GameObject medButt;
	public GameObject hardButt;

	void Start(){
		easyButt.SetActive (false);
		medButt.SetActive (false);
		hardButt.SetActive (false);
	}

	public void LoadDifficultyButtsLol(){
			easyButt.SetActive (true);
			medButt.SetActive (true);
			hardButt.SetActive (true);
			playButt.SetActive (false);
	}

	public void LoadTitleScreen(){
		soundManager.PlayOneShot (moreSound, 1f);
		Invoke ("LoadTitleDelay", 1f);
	}

	/// <summary>
	/// Load intro scene after playing sound & short delay.
	/// </summary>
	public void LoadIntro(){
		soundManager.PlayOneShot (yesSound1, 1f);
		Invoke ("LoadIntroDelay", 1f);
	}

	/// <summary>
	/// Load credits scene after playing a sound & short delay.
	/// </summary>
	public void LoadCredits(){
		soundManager.PlayOneShot (moreSound, 1f);
		Invoke ("LoadCreditsDelay", 1f);
	}

	/// <summary>
	/// Load the game after playing a sound & short delay.
	/// </summary>
	public void LoadGame(){
		soundManager.PlayOneShot (yesSound2, 1f);
		Invoke ("LoadGameDelay", 1f);
	}
		
	void LoadIntroDelay(){
		SceneManager.LoadScene (1);
	}
		
	void LoadCreditsDelay(){
		SceneManager.LoadScene (2);
	}

	void LoadGameDelay(){
		SceneManager.LoadScene (3);
	}

	void LoadTitleDelay(){
		SceneManager.LoadScene (0);
	}

	public void MakeEasy(){
		OverallGameManagerErik.numberToWin = 3;
	}

	public void MakeHard(){
		OverallGameManagerErik.numberToWin = 7;
	}

	public void MakeMedium(){
		OverallGameManagerErik.numberToWin = 5;
	}
}
