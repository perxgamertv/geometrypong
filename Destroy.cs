using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
	void Update () {
		Destroy(transform.gameObject,3f);
	}
}
