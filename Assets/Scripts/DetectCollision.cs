using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public enum ObstacleType {
        None,
        Wood,
        Point
    }

    public ObstacleType obstacleType;
    void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.name + " collided with " + gameObject.name);
        if (collision.gameObject.tag == "Boat") {
            GameObject boatGameManager = GameObject.FindGameObjectWithTag("BoatGameManager");
            if (obstacleType == ObstacleType.Wood) {
                boatGameManager.GetComponent<BoatGameManager>().RemoveLife();
            }
            else if (obstacleType == ObstacleType.Point) {
                boatGameManager.GetComponent<BoatGameManager>().AddPoint();
            }
            Destroy(gameObject);
        }
    }
}
