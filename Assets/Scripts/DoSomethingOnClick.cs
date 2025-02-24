using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoSomethingOnClick : MonoBehaviour
{
    [SerializeField] UnityEvent onClicked;
    [SerializeField] UnityEvent onReleased;

    public void InvokePressEvent() {
        onClicked.Invoke();
    }

    public void InvokeReleaseEvent() {
        onReleased.Invoke();
    }
}
