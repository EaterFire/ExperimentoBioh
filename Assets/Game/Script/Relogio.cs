using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relogio : MonoBehaviour {

	public static float delay = 2.0f;
	public static bool trigger;

	// Use this for initialization
	void Start () {
		trigger = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver()
	{
		if(Input.GetMouseButtonDown(0)){
			Destroy(gameObject);
			Time.timeScale = 0.5f;
			trigger = true;
}
	}


	void OnCollisionEnter2D	(Collision2D colisor)
	{
		if (colisor.gameObject.tag == "Poço")
			Destroy (gameObject);
}
}