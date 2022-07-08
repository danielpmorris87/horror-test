using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadController : MonoBehaviour
{
    public GameObject[] teleportPoints;
    //public GameObject playerCharacter;

    void Start()
    {
        FindTeleportPoints();
        FindPlayerGameObject();
        MovePlayerToTP();
    }

    void FindTeleportPoints()
    {
        teleportPoints = GameObject.FindGameObjectsWithTag("TeleportPoint");
    }

    void FindPlayerGameObject()
    {
        //playerCharacter = GameObject.FindGameObjectWithTag("Player");
    }

    static void MovePlayerToTP()
    {
        DoorController myObj = new DoorController();
        Debug.Log(myObj);
    }
}