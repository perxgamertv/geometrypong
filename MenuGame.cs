using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuGame : MonoBehaviour {

	public void RestartGame()
	{
		SceneManager.LoadScene("SinglePlayer");
	}

	public void BackToMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}
