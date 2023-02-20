using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint;

    public void DieAndRespawn()
    {
        Debug.Log("NOOOOO");
        transform.position = spawnPoint.transform.position;
    }
}
