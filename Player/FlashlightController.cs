using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip flashlightClip;
    [SerializeField] private Light myFlashlight;

    public Transform cameraPosition;
    public Transform cameraRotation;

    void Update()
    {
        // Move and rotate flashlight with camera
        transform.position = cameraPosition.position;
        transform.rotation = cameraRotation.rotation;

        if (Input.GetKeyDown("f"))
        {
            if (InventoryController.Instance.HasFlashlight)
            {
                audioSource.PlayOneShot(flashlightClip);
                myFlashlight.enabled = !myFlashlight.enabled;
            }
        }
    }
}