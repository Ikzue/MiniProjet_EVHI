using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour {

    //Script d'ouverture des portes

    public bool is_opened = false;
    public Vector3 target;
    public float target_y = -2.2f;
    public float speed = 2f;
	// Use this for initialization
	void Start () {
        target = new Vector3(transform.position.x, target_y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        if (is_opened)
        {
            transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }

	}
}
