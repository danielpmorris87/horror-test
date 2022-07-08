using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightPickup : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            InventoryController.Instance.HasFlashlight = true;
            AudioSource.PlayClipAtPoint(_clip, transform.position);
            Destroy(gameObject);
        }
    }
}
