using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BolaSinglePlayer : MonoBehaviour {
	public float speed = 5f;
	public float forceimpulse;
	public AudioSource bateusom;
	public GameObject mypart;
	private GameObject spawngo;
	// Use this for initialization
	void Start () {
		float sx =  Random.Range(0,2) == 0 ? -1 : 1;
		float sy =  Random.Range(0,2) == 0 ? -1 : 1;

		GetComponent<Rigidbody>().velocity = new Vector3(speed*sx,speed*sy,0f);
		bateusom=GameObject.Find("SomBateu").GetComponent<AudioSource>();
//		enemypart=GameObject.Find("EnemyPart").GetComponent<ParticleSystem>();
//		mypart=GameObject.Find("MyPart").GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		GetComponent<Rigidbody>().AddForce(transform.forward*forceimpulse*Time.deltaTime);
	}
	void OnCollisionEnter(Collision other){
		if(other.gameObject.name=="PontoP1"){
			GameObject.Find("SpawnBola").GetComponent<SpawnBolaSingle>().pontomeu+=1;
			Destroy(transform.gameObject);
		}
			if(other.gameObject.name=="PontoP2"){
			GameObject.Find("SpawnBola").GetComponent<SpawnBolaSingle>().pontodele+=1;
			Destroy(transform.gameObject);
		}
		if(other.gameObject.tag == "Player"){
			bateusom.PlayOneShot(bateusom.clip);
			Instantiate(mypart,other.collider.transform.position,other.collider.transform.rotation);
		}
		if(other.gameObject.tag == "Enemy"){
			bateusom.PlayOneShot(bateusom.clip);
			Instantiate(mypart,other.collider.transform.position,other.collider.transform.rotation);
		}
	}
}
