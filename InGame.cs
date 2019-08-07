using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InGame : MonoBehaviour {

	void Update()
	{
		if(Input.GetButtonDown("U")){
			SceneManager.LoadScene("SinglePlayer");
		}
		if(Input.GetButtonDown("Y")){
			SceneManager.LoadScene("Menu");
		}
	}
}