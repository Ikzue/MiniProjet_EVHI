using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
    //Script gerant la vie des ennemis
    public int nbLife = 12;
    public GameObject ending_text; //Le texte affiche lors de la fin du jeu
    public void Start() {
        transform.gameObject.SetActive(false);
    }
    public void gotHit() {
        nbLife--;
        transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.black); //L'ennemi devient noir si il est touche
        if (nbLife == 0) {
            ending_text.SetActive(true);
            Destroy(gameObject);
        }
    }
}

