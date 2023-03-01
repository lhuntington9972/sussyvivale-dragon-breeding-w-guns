using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pHealth : MonoBehaviour
{
    private int health;

    // Start is called before the first frame update
    void Start() {
        health = 10;
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        health -= 1;

            if (health <= 0) {
                Destroy(this.gameObject);
            }
    }
}
