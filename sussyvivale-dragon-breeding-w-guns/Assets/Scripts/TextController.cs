using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextController : MonoBehaviour
{
    public GameObject player;
    public TMP_Text healthText;

    private pHealth health_script;
    private string hText;

    public GameObject screen;
    public TMP_Text dText;

    // Start is called before the first frame update
    void Start() {
        health_script = player.GetComponent<pHealth>();
    }

    // Update is called once per frame
    void Update() {
        hText = health_script.health.ToString();
        healthText.text = "Health = " + hText;

        if (health_script.die == true) {
            screen.SetActive(true);
            dText.text = "You Died!!!";
        }
    }
}
