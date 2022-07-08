using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // INCOMING SCENE/TELEPORTER/PLAYER INFORMATION
    public string IncomingScene { get; set; }
    public string IncomingTeleporter { get; set; }
    public GameObject playerCharacter;
    public GameObject telePoint;

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
        Debug.Log("Incoming scene: " + IncomingScene);
        Debug.Log("Incoming teleporter: " + IncomingTeleporter);
    }

    void Start()
    {
        //
    }

    public void TeleportToNewScene()
    {
        SceneManager.LoadScene(IncomingScene);
        MovePlayerAfterTP();
    }

    public void MovePlayerAfterTP()
    {
        GameObject telePoint = GameObject.Find(IncomingTeleporter);
        Debug.Log("Teleporter found: " + telePoint);
        //playerCharacter.transform.position = telePoint.transform.position;
    }
}