using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaves : MonoBehaviour
{

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    private int x;
    private int y;

    private int waitTime;

    private int[] waveNums;
    private int waveCount;
    private int waveNum;

    private bool running = false;

    private float instPointx;
    private float instPointy;

    private int randNum;

    // Start is called before the first frame update
    void Start() {
        waitTime = 3;
        waveNum = 0;
        waveCount = 0;

        x = 1;
        y = 1;

        waveNums = new int[] {2, 4, 5, 4, 5, 6, 7, 8, 6, 10, 11, 12, 10, 10, 8, 15, 20};
    }

    // Update is called once per frame
    void Update() {
        if (!running) {
            if (waveCount <= waveNums[waveNum]) {
                StartCoroutine(Loop());
                waitTime = 3;
            }
            else {
                waitTime = 10;
                waveNum += 1;
                waveCount = 0;
            }
        }
    }

    IEnumerator Loop() {
        running = true;

        yield return new WaitForSeconds(waitTime);

        instPointx = Random.Range(-4.2f, 4.2f);
        instPointy = Random.Range(-1.2f, 4.7f);

        randNum = Random.Range(1, 4);

        if (randNum == 1) {
            Instantiate(enemy1, new Vector3(instPointx, instPointy, 0), Quaternion.identity);
        }
        else if (randNum == 2) {
            Instantiate(enemy2, new Vector3(instPointx, instPointy, 0), Quaternion.identity);
        }
        else {
            Instantiate(enemy3, new Vector3(instPointx, instPointy, 0), Quaternion.identity);
        }

        waveCount += 1;

        running = false;
    }
}