using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextController : MonoBehaviour
{
    public pHealth pHealth;

    public TMP_Text healthText;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        healthText.text = pHealth.ToString();
    }
}
