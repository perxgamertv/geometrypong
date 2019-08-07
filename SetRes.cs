using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class SetRes : MonoBehaviour {

	public VideoPlayer video;
	void Start () 
	{
		Screen.SetResolution(1280,720,true,60);
		video.Play();
	}
}
