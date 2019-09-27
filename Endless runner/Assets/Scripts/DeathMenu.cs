using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

	public string mainMenuLevel;

    void Start()
    {
        Time.timeScale = 0f;
    }
	public void RestartGame(){
        Time.timeScale = 1f;
        FindObjectOfType<GameManager>().Reset();
	}

	public void QuitToMain(){
		SceneManager.LoadScene(mainMenuLevel);
	}
}
