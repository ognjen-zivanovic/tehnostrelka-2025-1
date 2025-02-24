using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public float speed = 0.2f;
    public Vector3 direction = new Vector3(0.0f, 0.0f, -1.0f);

    void Update()
    {
        transform.localPosition += direction * speed * Time.deltaTime;
        if (transform.localPosition.x < WaterBoundsInfo.minX) {
            transform.localPosition = new Vector3(WaterBoundsInfo.maxX, transform.localPosition.y, transform.localPosition.z);
        }
        if (transform.localPosition.x > WaterBoundsInfo.maxX) {
            transform.localPosition = new Vector3(WaterBoundsInfo.minX, transform.localPosition.y, transform.localPosition.z);
        }
        if (transform.localPosition.z < WaterBoundsInfo.minZ) {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, WaterBoundsInfo.maxZ);
        }
        if (transform.localPosition.z > WaterBoundsInfo.maxZ) {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, WaterBoundsInfo.minZ);
        }
    }
}
