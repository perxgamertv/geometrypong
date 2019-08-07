using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InputMenu : MonoBehaviour {

	void Update()
	{
		if(Input.GetButtonDown("A")){
			SceneManager.LoadScene("SinglePlayer");
		}
		if(Input.GetButtonDown("O")){
			Application.Quit();
		}
	}
}
