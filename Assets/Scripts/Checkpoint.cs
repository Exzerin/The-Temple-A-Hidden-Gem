using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;

    void Start()
    {
        gm = FindObjectOfType<GameMaster>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        Respawn respawn = other.GetComponent<Respawn>();
        if (other.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.position;
        }
        if (respawn != null)
        {
            Debug.Log("Setting spawn point of player to location of " + name);
            respawn.spawnPoint = gameObject.transform;
        }

    }

}
