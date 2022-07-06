using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFanSpin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 300.0f * Time.deltaTime, 0);
    }
}