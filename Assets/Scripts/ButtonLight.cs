using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLight : MonoBehaviour {
    public GameObject my_light;

    private void OnCollisionEnter(Collision other) {
        if (my_light) {
            my_light.GetComponent<LightBehavior>().enabled = true;
        }
    }
}
