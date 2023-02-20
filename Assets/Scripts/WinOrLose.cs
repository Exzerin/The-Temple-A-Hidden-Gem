using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOrLose : MonoBehaviour
{
    public GameObject WinUI;
    public GameObject LoseUI;
    public GameObject ChooseUI;
    //public GameObject interact;
    //private bool trigger;

    // Start is called before the first frame update
    void Start()
    {
        //interact.SetActive(false);
    }

    void Update()
    {
       
    }

    public void Continue()
    {
        SceneManager.LoadScene(0);
    }

    public void Choose()
    {
        ChooseUI.SetActive(true);
        Time.timeScale = 1;
    }

    public void Win()
    {
        ChooseUI.SetActive(false);
        WinUI.SetActive(true);
    }

    public void WinOff()
    {
        WinUI.SetActive(false);
    }

    public void Lose()
    {
        ChooseUI.SetActive(false);
        LoseUI.SetActive(true);
    }

    public void LoseOff()
    {
        LoseUI.SetActive(false);
    }
}
