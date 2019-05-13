using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    public event Action<bool> Detected;
    private string targetTag = "enemy";

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != targetTag)
        {
            return;
        }

        Detected?.Invoke(true);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag != targetTag)
        {
            return;
        }

        Detected?.Invoke(false);
    }
}
