using System;
using System.Collections;
using UnityEngine;

public class DoorController : Interactable
{
    [SerializeField] private bool doorIsLocked;
    public AudioClip doorLockedSound;
    public AudioClip doorOpenSound;
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
        else if (doorIsLocked == false)
        {
            AudioSource.PlayClipAtPoint(doorOpenSound, transform.position);
        }
        else
        {
            Debug.Log("Unknown error on the DoorController script");
        }
    }
}