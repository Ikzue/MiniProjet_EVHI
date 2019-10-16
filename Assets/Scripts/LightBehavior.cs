using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script d'allumage de la lumiere pour la salle du boss

public class LightBehavior : MonoBehaviour {
    private float intensity = 0;
    private float max_intensity = 5;
    private float step = 2f;
    private Light my_light;

    private void Start() {
        my_light = GetComponent<Light>();
        my_light.intensity = 0;
        this.enabled = false;
    }
    // Update is called once per frame
    void Update () {
        intensity += step * Time.deltaTime;
        intensity = Mathf.Clamp(intensity, 0, max_intensity);
        my_light.intensity = intensity;
	}

}
