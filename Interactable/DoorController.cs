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

    public string outgoingTelepoint { get; set; }

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
            SceneManager.LoadScene(sceneToTeleportTo);
        }
        else
        {
            Debug.Log("Unknown error on the DoorController script");
        }
    }
}