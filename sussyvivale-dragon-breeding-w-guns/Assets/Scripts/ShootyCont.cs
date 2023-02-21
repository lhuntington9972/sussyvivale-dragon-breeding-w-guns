using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyCont : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private Vector2 thrust;

    // Start is called before the first frame update
    void Start() {
        rb2D = this.gameObject.GetComponent<Rigidbody2D>();
        thrust = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update() {
        rb2D.AddForce(thrust);
    }
}
