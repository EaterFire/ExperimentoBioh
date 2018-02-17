using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour {
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
			Player.vida -= 1;

	}

	void OnMouseOver()
	{
		Destroy(gameObject);
		Player.score += 10;
		/*if(Input.GetMouseButtonDown(0)){
			Destroy(gameObject);
			Player.score += 10;
		}*/
	}
}
	
