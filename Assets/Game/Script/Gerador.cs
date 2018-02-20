using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerador : MonoBehaviour {

	[SerializeField]
	private Text contador;

	public float  Tempo;

	public Transform BolinhaPreta;
	public Transform Cronometro;
	public Transform Plati;

	public float spawnDelay;
	public int diffT;

	// Use this for initialization
	IEnumerator Start () {
		spawnDelay = 2.0f;
		diffT = 10;

		InvokeRepeating("Spawn2", 2.0f, 5);
		InvokeRepeating("Spawn3", 1.0f, 5);


		while(true)
		{
			yield return new WaitForSeconds(spawnDelay);
			Spawn();
		}


	}
	
	// Update is called once per frame
	void Update () {

		Tempo += Time.deltaTime;
		contador.text = Tempo.ToString();
	
		//Dificuldade

		//Debug.Log ("Tempo:" + Mathf.FloorToInt (Tempo) + "Diff:" + diffT);

		if (Mathf.FloorToInt(Tempo) == diffT && Mathf.FloorToInt(Tempo)== 10) {
			Player.vida = Player.vida /2 ;
			spawnDelay -= 0.3f;
			diffT += 10;
		}
		else if (Mathf.FloorToInt(Tempo) == diffT && Mathf.FloorToInt(Tempo) ==20) {
			Player.vida = Player.vida /2 ;
			spawnDelay -= 0.4f;
			diffT += 10;
		}
		else if (Mathf.FloorToInt(Tempo) == diffT && Mathf.FloorToInt(Tempo) ==30) {
			Player.vida = Player.vida /2 ;
			spawnDelay -= 0.5f;
			diffT += 10;
		}
		else if (Mathf.FloorToInt(Tempo) == diffT && Mathf.FloorToInt(Tempo)==40) {
			Player.vida = Player.vida /2 ;
			spawnDelay -= 0.6f;
			diffT += 10;
		}else if (Mathf.FloorToInt(Tempo) == diffT && Mathf.FloorToInt(Tempo) == 50){
			Player.vida = 10;
			spawnDelay = 0.2f;
		}
			

		if (Relogio.trigger == true) {
			Relogio.delay -= Time.deltaTime;
		}

		if (Relogio.delay <= 0) {
			Time.timeScale = 1;
			Relogio.delay = 2;
			Relogio.trigger = false;
		}


		//Debug.Log (spawnDelay);
	}

	void Spawn(){
		Vector3 position = new Vector3 (Random.Range (-2.62f, 2.56f), 5.42f, 0);
		Instantiate (BolinhaPreta, position, Quaternion.identity);

	}
	void Spawn2(){
		Vector3 position = new Vector3 (Random.Range (-2.62f, 2.56f), 5.42f, 0);
		Instantiate (Cronometro, position, Quaternion.identity);


	}
	void Spawn3(){
		Vector3 position = new Vector3 (Random.Range (-2.62f, 2.56f), 5.42f, 0);
		Instantiate (Plati, position, Quaternion.identity);


	}
}