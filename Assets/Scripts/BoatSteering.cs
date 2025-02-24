using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatSteering : MonoBehaviour
{
    [SerializeField] Renderer waveMaterial;
    float totalAngle = 0.0f;
    public void SteerDirection(float angle)
    {
        totalAngle += angle;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.up);
        //for each child
        foreach (Transform child in transform)
        {
            //rotate localposition around 0,0 by angle
            child.localPosition = rotation * child.localPosition;
        }
        waveMaterial.material.SetFloat("_Rotation", -totalAngle);
    }
}
