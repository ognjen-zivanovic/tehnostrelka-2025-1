using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        // Debug.Log(collision.gameObject.tag);
        // if (collision.gameObject.tag == "Boat") {
            GameObject boatGameManager = GameObject.FindGameObjectWithTag("BoatGameManager");
            boatGameManager.GetComponent<BoatGameManager>().RemoveLife();
            Destroy(gameObject);
        // }
    }
}
