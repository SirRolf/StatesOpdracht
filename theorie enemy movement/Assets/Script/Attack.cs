using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public event Action<bool> Attacking;
    private string targetTag = "enemy";

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != targetTag)
        {
            return;
        }
        Attacking?.Invoke(true);
    }

    void OntriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag != targetTag)
        {
            return;
        }
        Attacking?.Invoke(false);
    }
}
