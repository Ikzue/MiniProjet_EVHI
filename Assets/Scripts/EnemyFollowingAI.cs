using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script de deplacement d'un ennemi suivant le joueur

public class EnemyFollowingAI : MonoBehaviour {
    public float speed = 1.5f;
    public GameObject player;
    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
