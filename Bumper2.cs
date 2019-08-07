using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Bumper2 : NetworkBehaviour {

	// Use this for initialization
	public Material thismaterial;
	public float speed = 20;
	public bool isPlayer2;
	void Start () {
		transform.GetComponent<Renderer>().material = thismaterial;
	}
	
	// Update is called once per frame
	void Update () {
		if(isLocalPlayer==false && isPlayer2==true){
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
	}
}

	//	}		
	//		if(transform.position.z>-6.5f){

