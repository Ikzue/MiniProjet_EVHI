using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script de deplacement aleatoire d'un ennemi
public class EnemyWanderingAI : MonoBehaviour {
    public float speed = 5.0f;
    public float buffer = 3.0f; //Change de direction toutes les trois secondes
    public float time = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time > buffer)
        {
            transform.Rotate(new Vector3(0, Random.Range(-60f, 60f), 0));
            time = 0;
        }
        transform.Translate(transform.forward*speed*Time.deltaTime);
    }


    private void OnCollisionEnter(Collision collision)
    {
        transform.Rotate(new Vector3(0,120f,0));
    }
}
