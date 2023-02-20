using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    void start()
    { 

        //Color color = Color.red;
        //float f = 0.4f;

        //material.SetColor("_EmissionColor", Color.red);

        //GetComponent<Renderer>().material.color = color;
        //GetComponent<Renderer>().material.SetColor("_EmissionColor", color * f);
        //material.EnableKeyword("_EMISSION");
    }

    public void TriggerDialogue()
    {

        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
