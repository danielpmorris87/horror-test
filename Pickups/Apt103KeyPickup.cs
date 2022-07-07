using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apt103KeyPickup : Interactable
{
    [SerializeField] private AudioClip _clip;

    protected override void Interact()
    {
        InventoryController.hasApt103Key = true;
        AudioSource.PlayClipAtPoint(_clip, transform.position);
        Destroy(gameObject);
    }
}