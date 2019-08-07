using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class BumperSinglePlayer : MonoBehaviour {

	// Use this for initialization
	public Material p1mat,p2mat;
	public float speed = 20;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
			if(transform.position.z<4){
			if(Input.GetAxis("Vertical") > 0){
			this.transform.Translate(-speed*Time.deltaTime,0,0);
			}
			}
			if(transform.position.z>-6.5f){
			if(Input.GetAxis("Vertical") < 0){
			this.transform.Translate(speed*Time.deltaTime,0,0);
			}
			}
	}
}