using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBoatY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.localPosition;
        pos.y = 0.0f;
        Vector2 direction = new Vector2(1.5f, 1.0f);
        float frequency = 1.0f;
        float speed = 1.0f;
        float amplitude = 0.03f;
        pos.x *= direction.x;
        pos.z *= direction.y;

        float a = pos.x;
        a *= frequency;
        a -= (Time.time * speed);
        a = Mathf.Sin(a);
        a *= amplitude;

        float b = pos.z;
        b *= frequency;
        b -= (Time.time * speed);
        b = Mathf.Sin(b);
        b *= amplitude;

        a = pos.y - a;
        b = pos.y - b;

        float c = a + b;
        transform.localPosition = new Vector3(transform.localPosition.x, c, transform.localPosition.z);
    }



}
