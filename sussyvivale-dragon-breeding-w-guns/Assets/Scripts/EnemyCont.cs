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
    void Start()
    {
        if (this.gameObject.tag == "Enemy1")
        {
            moveSpeed = 3;
            health = Random.Range(11, 13);
        }
        else if (this.gameObject.tag == "Enemy3")
        {
            moveSpeed = 3;
            health = Random.Range(8, 10);
        }
        else
        {
            moveSpeed = 6;
            health = Random.Range(3, 5);
        }

        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (target.position - transform.position).normalized;

        moveDir = direction;

        if (moveDir.x < 0 && m_FacingRight == true)
        {
            FlipLeft();
        }
        else if (moveDir.x > 0 && m_FacingRight == false)
        {
            FlipRight();
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDir.x, moveDir.y) * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            health -= 1;

            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    private void FlipLeft()
    {

        if (m_FacingRight == true)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1f;
            transform.localScale = theScale;

            m_FacingRight = false;
        }
    }

    private void FlipRight()
    {
        if (m_FacingRight != true)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1f;
            transform.localScale = theScale;

            m_FacingRight = true;
        }
    }
}