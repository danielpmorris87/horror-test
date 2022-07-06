using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMessageController : MonoBehaviour
{
    private PlayerUI playerUI;

    private void Start()
    {
        playerUI = GetComponent<PlayerUI>();
    }

    void Update()
    {
        // Reset the text in the UI prompt
        playerUI.UpdateMessageText(string.Empty);
    }
}
