using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    //public GameObject player;
    private GameObject triggerNPC;
    private bool trigger;
    private bool trigger2;
    private bool trigger3;

    public GameObject npcText;
    public GameObject interact;

    private GameObject dt;
    public GameObject t;

    void Update()
    {
        //dt = FindObjectOfType<DialogueTrigger>();

        if (trigger == false)
        {
            npcText.SetActive(false);
        }
        else if (trigger == true)
        {
            npcText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                trigger2 = true;
                dt.GetComponent<DialogueTrigger>().TriggerDialogue();
            }
            if (trigger2)
            {
                npcText.SetActive(false);
            }

        }

        if (trigger3 == true)
        {
            interact.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                trigger3 = false;
                t.GetComponent<WinOrLose>().Choose();
                //Choose();
            }
            if (trigger3 == false)
            {
                interact.SetActive(false);
            }
        }
        else if (trigger3 == false)
        {
            interact.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "NPC")
        {
                trigger = true;
                triggerNPC = other.gameObject;
                dt = other.gameObject;
            //dt = collision.gameObject.GetComponent<BasicNPCPrototype>();
        }
        if (other.tag == "Artifact")
        {
            trigger3 = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "NPC")
        {
            trigger = false;
            triggerNPC = null;
            trigger2 = false;
        }
        if (other.tag == "Artifact")
        {
            trigger3 = false;
        }
    }

    /***public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {

        PlayerData data = SaveSystem.LoadPlayer();


        Vector3 position;

        position.x = data.position[0];

        position.y = data.position[1];

        position.z = data.position[2];

        transform.position = position;

    }***/
}
