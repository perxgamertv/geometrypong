using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnemyIA : MonoBehaviour {

	// Use this for initialization

	public GameObject bola;
	public float smooth;
	 private Vector3 velocity = Vector3.zero;
	void Start () 
	{

	}
	void Update() 
	{
		bola = GameObject.FindWithTag("Bola");
		
		if(bola!=null){
		Vector3 targetPosition = (new Vector3(transform.position.x, transform.position.y, bola.transform.position.z));
		transform.position= Vector3.SmoothDamp(transform.position,targetPosition,ref velocity, smooth);
		}
	}
}
