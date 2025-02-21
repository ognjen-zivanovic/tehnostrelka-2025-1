using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoSomethingOnClick : MonoBehaviour
{
    [SerializeField] UnityEvent onClicked;

    public void InvokeEvent() {
        onClicked.Invoke();
        GetComponent<Renderer>().material.SetFloat("_GlowIntensity", 0.0f);
    }
}
