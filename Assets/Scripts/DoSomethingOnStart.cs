using UnityEngine;
using UnityEngine.Events;

public class DoSomethingOnStart : MonoBehaviour
{
    [SerializeField] UnityEvent onClicked;

    void Start()
    {
        onClicked.Invoke();
    }
}
