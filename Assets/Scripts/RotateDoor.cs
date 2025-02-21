using UnityEngine;
using System.Collections;

public class RotateDoor : MonoBehaviour
{
    public float rotationDuration = 1f; // Time to complete rotation
    private bool isRotating = false;
    float angle = -90.0f;

    public void StartRotation()
    {
        if (!isRotating) {
            StartCoroutine(RotateOverTime());
            angle *= -1;
        }
    }

    private IEnumerator RotateOverTime()
    {
        isRotating = true;
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = Quaternion.Euler(0, transform.eulerAngles.y + angle, 0);
        float elapsedTime = 0f;

        while (elapsedTime < rotationDuration)
        {
            transform.rotation = Quaternion.Slerp(startRotation, endRotation, elapsedTime / rotationDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.rotation = endRotation;
        isRotating = false;
    }
}