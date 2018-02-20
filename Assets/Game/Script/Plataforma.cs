using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D	(Collision2D colisor)
	{
		if (colisor.gameObject.tag == "Poço")
			Destroy (gameObject);

	}
	void OnMouseOver()
	{
		if(Input.GetMouseButtonDown(0)){
			Destroy(gameObject);
			Lerp.ativo = true;
		}
}
}
