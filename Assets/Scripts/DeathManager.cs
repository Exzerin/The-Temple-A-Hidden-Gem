using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeathManager : MonoBehaviour
{
    // public GameObject UI;

    // TMP_Text counter;

    public int deaths = 0;

    private DeathCounter dc;

    // public Text deathText;
    // public Text Counter;

    /*void Awake()
    {
        // counter = GetComponent<TMP_Text>();
        dc = GameObject.FindObjectOfType<DeathCounter>();
    }*/

    void Update()
    {
        // counter.text = "DEATH: ";
    }

    public void IncreaseDeaths()
    {
        deaths += 1;
        // deathText.text = deaths.ToString();
        DeathCounter.deaths += 1;

    }

    /*void SetText()
    {
        DeathCounter();
    }*/
}
