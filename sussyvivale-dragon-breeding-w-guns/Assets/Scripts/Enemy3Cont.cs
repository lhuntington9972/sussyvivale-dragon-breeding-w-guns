using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Cont : MonoBehaviour
{
    private float dirx;
    private float diry;

    private float rand1;
    private float rand2;

    private Transform target;

    public GameObject bomb;

    private bool running = false;

    // Start is called before the first frame update
    void Start() {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update() {
        dirx = transform.position.x + rand1;
        diry = transform.position.y + rand2;

        if (!running) {
            StartCoroutine(BOMB());
        }
    }

    IEnumerator BOMB() {
        running = true;

        yield return new WaitForSeconds(3);

        Instantiate(bomb, new Vector3(dirx, diry, 0), Quaternion.identity);

        rand1 = Random.Range(-1f, 1f);
        rand1 = Random.Range(-1f, 1f);

        running = false;
    }
}
