using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterSeconds : MonoBehaviour
{
    public float timeToDelete = 5f;
    public bool random = false;

    void Start()
    {
        if (random) timeToDelete = Random.Range(0, timeToDelete);
        Invoke("DeleteObject", timeToDelete);
    }

    void DeleteObject()
    {
        Destroy(gameObject);
    }
}
