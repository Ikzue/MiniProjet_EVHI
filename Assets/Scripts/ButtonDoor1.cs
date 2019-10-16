using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoor1 : MonoBehaviour {
    //Ouvrir la porte des qu'on touche l'objet du script.
    public string porte_a_ouvrir = "Porte1";

    private void OnCollisionEnter(Collision other)
    {
        GameObject porte = GameObject.Find(porte_a_ouvrir);
        if (porte)
        {
            porte.GetComponent<DoorBehaviour>().is_opened = true;
        }
    }
}
