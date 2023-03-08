using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCont : MonoBehaviour
{
    private int health;

    private float moveSpeed;
    private Rigidbody2D rb;

    private Transform target;

    private Vector2 moveDir;

    private bool m_FacingRight = true;

    // Start is called before the first frame update
    void Start() {
        if (this.gameObject.tag == "Enemy1") {
            moveSpeed = 3;
            health = Random.Range(11, 13);
        }
        else if (this.gameObject.tag == "Enemy3") {
            moveSpeed = 1;
            health = Random.Range(8, 10);
        }
        else {
            moveSpeed = 6;
            health = Random.Range(3, 5);
        }

        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update() {
        Vector3 direction = (target.position - transform.position).normalized;

        moveDir = direction;

        if (moveDir.x < 0) {
            Flip();
        }
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(moveDir.x, moveDir.y) * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Bullet") {
            health -= 1;

            if (health <= 0) {
                Destroy(this.gameObject);
            }
        }
    }

    private void Flip()
	{
		// Switch the way the player is labelled as facing.
		m_FacingRight = !m_FacingRight;

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
