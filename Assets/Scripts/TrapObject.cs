using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(BoxCollider2D))]

public class TrapObject : MonoBehaviour
{

    public static TrapObject instance;

    public AudioSource die;

    private DeathManager dm;

    void Awake() // as soon as the game starts or when the script gets called?
    {
        dm = GameObject.FindObjectOfType<DeathManager>();
    }

    void start()
    {
        die = GetComponent<AudioSource>();
    }

    /*void update()
    {
        // DontDestroyOnLoad(instance);
        // print("Death counter: " + death);
    }*/

    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    /***private void OnTriggerEnter2D(Collider2D collision)
    {
        //Respawn respawn = other.GetComponent<Respawn>();

        if(collision.tag=="Player")
        {
            Debug.Log($"{name} Triggered");

            // FindObjectOfType<LifeCount>().LoseLife();
        }
        if (respawn !=null)
        {
            Debug.Log("Player ran into " + name);
            respawn.DieAndRespawn();
        }
    }***/

    void OnTriggerEnter2D(Collider2D other)
    { 
        Respawn respawn = other.GetComponent<Respawn>();
        if (other.tag == "Player")
        {

            /*Debug.Log($"{name} Triggered");

            FindObjectOfType<LifeCount>().LoseLife();*/
        }
        if (respawn != null)
        {
            die.Play();
            Debug.Log("Player ran into " + name);
            respawn.DieAndRespawn();
            dm.IncreaseDeaths();
        }

    }
}
