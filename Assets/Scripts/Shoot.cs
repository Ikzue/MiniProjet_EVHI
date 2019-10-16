using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shoot : MonoBehaviour {
    //Script de tir du joueur
    public Rigidbody projectile;
    public float speed = 500.0f;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Rigidbody rocketInstance;
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); //Rayon correspondant au centre de la camera
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.black, 10.0f);
            rocketInstance = Instantiate(projectile, transform.position+transform.forward*2,transform.rotation);
            rocketInstance.AddForce(ray.direction*speed);
        }
		
	}
}
