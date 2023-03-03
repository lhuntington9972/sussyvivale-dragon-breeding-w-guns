using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pHealth : MonoBehaviour
{
    public int health;

    // Start is called before the first frame update
    void Start() {
        health = 10;
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy") {
            health -= 1;
        }

        if (health <= 0) {
            Destroy(this.gameObject);
        }
    }
}