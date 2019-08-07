using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SlapimageControl : MonoBehaviour {
	public float time;
	void Update () {
		if(time<=0){
			SceneManager.LoadScene("Menu");
		}
		if(time>0){
			time -= Time.deltaTime;
		}
	}
}
