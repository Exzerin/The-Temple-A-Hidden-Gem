using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    public static int deaths = 0;
    TMP_Text counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<TMP_Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = "DEATHS: " + deaths;
    }
}
