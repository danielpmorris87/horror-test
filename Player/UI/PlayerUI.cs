using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private TextMeshProUGUI messageText;

    public void UpdatePromptText(string promptMessage)
    {
        promptText.text = promptMessage;
    }

    public void UpdateMessageText(string messageMessage)
    {
        messageText.text = messageMessage;
    }
}
