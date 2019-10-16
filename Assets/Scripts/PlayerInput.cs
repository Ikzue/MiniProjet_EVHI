using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    //Input de l'utilisateur: Deplacement au clavier et a la souris horizontalement
    public float speed = 5.0f;
	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
            movement += -transform.right;

        if (Input.GetKey(KeyCode.RightArrow))
            movement += transform.right;

        if (Input.GetKey(KeyCode.UpArrow))
            movement += transform.forward;

        if (Input.GetKey(KeyCode.DownArrow))
            movement += -transform.forward;
        transform.position += movement * speed * Time.deltaTime;

        float hor = Input.GetAxis("Mouse X") * speed ;

        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + hor, 0);
    }
}
