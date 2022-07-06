using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoadController : MonoBehaviour
{
    public GameObject[] teleportPoints;

    void Start()
    {
        teleportPoints = GameObject.FindGameObjectsWithTag("TeleportPoint");
    }
}