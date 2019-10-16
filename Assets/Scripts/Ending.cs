using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script de fin du jeu
public class Ending : MonoBehaviour {
    private float timer = 0f;
    private float ending_time = 5f;

	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > ending_time)
            Application.Quit();
	}
}
