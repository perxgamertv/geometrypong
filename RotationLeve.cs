using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLeve : MonoBehaviour {

	// Use this for initialization
	public float speedrot;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,speedrot*Time.deltaTime,0);
	}
}
