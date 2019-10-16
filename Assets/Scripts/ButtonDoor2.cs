using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoor2 : MonoBehaviour {
    //Ouvrir la porte des qu'on touche le bouton et on a elimine l'ennemi
    public string porte_a_ouvrir = "Porte2";
    public string ennemi_a_eliminer = "Enemy1";
    private void OnCollisionEnter(Collision other)
    {
        GameObject porte = GameObject.Find(porte_a_ouvrir);
        GameObject enemy = GameObject.Find(ennemi_a_eliminer);
        if (porte && !enemy)
        {
            Debug.Log(porte_a_ouvrir);
            porte.GetComponent<DoorBehaviour>().is_opened = true;
        }
    }
}
