using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    private Camera mainCam;
    private Vector3 mousePos;

    public GameObject bullet;
    public Transform instPoint;

    private Vector3 inst;

    // Start is called before the first frame update
    void Start() {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        inst = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        inst = instPoint.position;

        if (Input.GetMouseButtonDown(0)) {
            Instantiate(bullet, inst, Quaternion.identity);
        }
    }
}
