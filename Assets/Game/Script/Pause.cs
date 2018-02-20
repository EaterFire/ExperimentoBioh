using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject menu;
	private static bool pausado = false;

	public static bool getPausado()   {
		return pausado;
	}

	void Update() {
		if (Input.GetButtonDown("Cancel")) {
			menu.SetActive(true);
			Time.timeScale = 0;
			pausado = true;
		}
	}
}