using System.Collections.Generic;
using UnityEngine;

public class TeleportPoint : MonoBehaviour
{
    private Renderer[] rend;

    void Start()
    {
        rend = GetComponentsInChildren<Renderer>();

        foreach (Renderer r in rend)
        r.enabled = false;
    }
}