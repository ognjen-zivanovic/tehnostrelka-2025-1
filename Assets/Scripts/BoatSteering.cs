using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatSteering : MonoBehaviour
{
    [SerializeField] GameObject boat;
    public void SteerDirection(float angle)
    {
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.up);
        BoatMovement.direction = rotation * BoatMovement.direction;
        boat.transform.localRotation = rotation * boat.transform.localRotation;
    }
}
