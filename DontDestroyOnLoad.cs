using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

	// Use this for initialization
	public GameObject[] Som;
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
		Som = GameObject.FindGameObjectsWithTag("Som");
		if(Som.Length>1){
			Destroy(Som[0].gameObject);
		}
	}
}
