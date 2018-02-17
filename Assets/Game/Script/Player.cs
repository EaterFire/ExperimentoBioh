using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	 public static int vida;
	 public static int score;

	[SerializeField]
	private Text scoreCount;
	[SerializeField]
	private Text lifeCount;

	// Use this for initialization
	void Start () {
		vida = 100;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Vida: " + vida);
		//Debug.Log ("Score: " + score);

		scoreCount.text = score.ToString ();
		lifeCount.text = vida.ToString ();

		if(vida <= 0){
			Morrer ();
		}
	}

	void Morrer(){
		Time.timeScale = 0;
		//Debug.Log ("MORRI");
	}
}


