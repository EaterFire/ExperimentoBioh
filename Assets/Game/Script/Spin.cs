using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.deltaTime > 0) {
			transform.Rotate (Vector3.forward);
			transform.Rotate (Vector3.forward);
		}
	}
}
