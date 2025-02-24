using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatSteeringButton : MonoBehaviour
{
    public float steerSpeed = 20f;
    bool isSteering = false;

    [SerializeField] GameObject steeringObject;
    void Update()
    {
        if (isSteering) {
            steeringObject.GetComponent<BoatSteering>().SteerDirection(steerSpeed * Time.deltaTime);
        }
    }
    public void StartSteering() {
        isSteering = true;
    }

    public void EndSteering() {
        isSteering = false;
    }
}
