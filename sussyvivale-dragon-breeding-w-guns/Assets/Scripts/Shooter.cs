using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject shooty;
    public Vector3 pos;
    public float posx;
    public float posy;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("space")) {
            posx = this.gameObject.transform.position.x;
            posy = this.gameObject.transform.position.y;

            pos = new Vector3(posx + 0.5f, posy + 0.5f, 0.5f);
            Instantiate(shooty, pos, Quaternion.identity);
        }
    }
}
