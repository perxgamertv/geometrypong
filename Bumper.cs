using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Bumper : NetworkBehaviour {

	// Use this for initialization
	public Material p1mat,p2mat;
	public float speed = 20;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(isLocalPlayer==true){
			Debug.Log("isLocal");
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

		if(isLocalPlayer==true){
			transform.GetComponent<Renderer>().material = p1mat;
		}
		if(isLocalPlayer==false){
			transform.GetComponent<Renderer>().material = p2mat;
		}
	}
}