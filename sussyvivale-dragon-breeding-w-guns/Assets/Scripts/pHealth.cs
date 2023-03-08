using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pHealth : MonoBehaviour
{
    public int health;
    public bool die;

    // Start is called before the first frame update
    void Start() {
        health = 3;
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy1" || other.gameObject.tag == "Enemy2" || other.gameObject.tag == "Bomb") {
            health -= 1;
        }

        if (health <= 0) {
            die = true;
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        health = 0;
        die = true;
    }
}
