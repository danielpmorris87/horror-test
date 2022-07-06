using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    private int rayLength = 1;
    [SerializeField] private LayerMask layerMaskInteract;
    private PlayerUI playerUI;

    private void Start()
    {
        playerUI = GetComponent<PlayerUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // Reset the text in the UI prompt
        playerUI.UpdatePromptText(string.Empty);

        RaycastHit hitInfo;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hitInfo, rayLength, layerMaskInteract.value))
        {
            if (hitInfo.collider.GetComponent<Interactable>()!= null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdatePromptText(interactable.promptMessage);

                if (Input.GetKeyDown("e"))
                {
                    interactable.BaseInteract();
                }
            }
        }
    }
}
