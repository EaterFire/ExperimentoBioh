using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Lerp : MonoBehaviour {
	private Vector3 startpos;
	public Transform endpos;

	private float speed;
	public static bool ativo = false;
	private float delay = 3.0f;
	
	// Use this for initialization
	void Start () {
		startpos = gameObject.transform.position;

	}

	// Update is called once per frame
	void Update () {
		if (ativo == true){
			delay -= Time.deltaTime;
			speed += 0.009f;
			transform.position = Vector3.Lerp(startpos,endpos.position,speed);
			Debug.Log ("T: " + delay);
		}
		if (delay <= 0){
			ativo = false;
			speed -= 0.009f;
			transform.position = Vector3.Lerp(endpos.position,startpos,speed);
			delay = 3.0f;
		}
	}
}
