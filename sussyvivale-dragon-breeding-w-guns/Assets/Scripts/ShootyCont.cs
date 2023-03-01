using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyCont : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 mousePos;
    private Camera mainCam;
    public float force;

    // Start is called before the first frame update
    void Start() {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;

        force = 10;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }

    // Update is called once per frame
    void Update() {
    }

    void OnCollisionEnter2D(Collision2D other) {
        Destroy(this.gameObject);
    }
}
