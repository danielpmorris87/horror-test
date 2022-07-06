using System.Collections.Generic;
using UnityEngine;

public class TeleportPoint : MonoBehaviour
{
    private Renderer[] rend;

    void Start()
    {
        rend = GetComponentsInChildren<Renderer>();

        foreach (Renderer rend in rend)
        rend.enabled = false;
    }
}