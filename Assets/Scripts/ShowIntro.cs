using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowIntro : MonoBehaviour
{
    public GameObject introUI;

    // Start is called before the first frame update
    void Start()
    {
        introUI.SetActive(true);
    }

    // Update is called once per frame
    public void TurnOff()
    {
       introUI.SetActive(false);
    }
}
