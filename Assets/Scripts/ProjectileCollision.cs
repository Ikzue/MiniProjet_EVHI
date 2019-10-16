using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour {
    //Gestion collision des projectiles 

    public float destroyTime = 2.0f;
    private void OnCollisionEnter(Collision collision)
    {
        Enemy e = collision.gameObject.GetComponent<Enemy>();
        Boss b = collision.gameObject.GetComponent<Boss>();
        if (e){
            e.gotHit();
            Destroy(gameObject);
        }
        if(b) {
            b.gotHit();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        Destroy(gameObject, destroyTime);
    }
}
