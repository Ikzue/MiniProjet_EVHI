using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    //Script gerant la vie des ennemis
    public int nbLife = 3;
    public void Start() {
        transform.gameObject.SetActive(false);
    }
    public void gotHit()
    {
        nbLife--;
        transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.black); //L'ennemi devient noir si il est touche
        if (nbLife == 0)
        {
            Destroy(gameObject);
        }
    }
}
