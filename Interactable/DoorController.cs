using System;
using System.Collections;
using UnityEngine;

public class DoorController : Interactable
{
    [SerializeField] private bool doorIsLocked;
    [SerializeField] private AudioClip doorLockedSound;
    [SerializeField] private AudioClip doorOpenSound;
    public string outgoingScene;
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
            AudioSource.PlayClipAtPoint(doorOpenSound, transform.position);
            SceneController.Instance.IncomingScene = outgoingScene;
            SceneController.Instance.IncomingTeleporter = outgoingTelepoint;
            SceneController.Instance.TeleportToNewScene();
        }
    }
}