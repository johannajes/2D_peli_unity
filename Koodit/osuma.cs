using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class osuma : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void onCollisionEnter2D(Collision2D collision){   
        Debug.Log("osuma");    
        ProcessCollision(collision.gameObject);
    }
    private void onTriggerEnter2D(Collider2D collider){   
        Debug.Log("osuma");    
        ProcessCollision(collider.gameObject);
    }
    void ProcessCollision(GameObject collider) {
        Debug.Log("Pistelasku");
        if (collider.CompareTag("Coin")) {
            //this rigidbody hit the player
            Destroy(Kolikkotehdas.instance.apukolikko);
            pisteet.instance.AddPoint();
        } 
    }
}

