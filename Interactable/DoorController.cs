using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : Interactable
{
    [SerializeField] private bool doorIsLocked;
    [SerializeField] private AudioClip doorLockedSound;
    [SerializeField] private AudioClip doorOpenSound;
    public string sceneToTeleportTo;
    public string outgoingTelepoint;

    protected override void Interact()
    {
        // Check to see if door is locked
        // If so, play doorLockedSound
        if (doorIsLocked)
        {
            AudioSource.PlayClipAtPoint(doorLockedSound, transform.position);
        }
        else
        {
            outgoingTelepoint = SceneController.Instance.incomingTelepoint;
            AudioSource.PlayClipAtPoint(doorOpenSound, transform.position);
            SceneController.Instance.IncomingTeleport();
            //SceneManager.LoadScene(sceneToTeleportTo);
        }
    }
}