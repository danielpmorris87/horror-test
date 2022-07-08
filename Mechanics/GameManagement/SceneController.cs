using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // VARS
    public GameObject playerCharacter;
    public string incomingTelepoint;

    private static SceneController _instance;
    public static SceneController Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("SceneController is NULL");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        //Debug.Log("Incoming teleport: " + incomingTelepoint);
    }

    public void IncomingTeleport()
    {
        Debug.Log("Incoming teleport: " + incomingTelepoint);
    }
}