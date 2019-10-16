using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnemy : MonoBehaviour {
    public GameObject enemy_to_activate;
    // Use this for initialization
    private void OnCollisionEnter(Collision other) {
        if (enemy_to_activate) {
            enemy_to_activate.SetActive(true);
        }
    }
}
