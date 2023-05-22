using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent customEvent;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            customEvent.Invoke();
        }
    }
}
