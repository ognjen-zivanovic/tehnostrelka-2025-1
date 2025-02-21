using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatGameManager : MonoBehaviour
{
    public static int numLives = 3;

    [SerializeField] GameObject[] livesIndicatorObjects;
    [SerializeField] GameObject endScreenObject;
    [SerializeField] GameObject obstacleContainer;
    [SerializeField] GameObject pool;

    public void ResetGame() {
        numLives = 3;
        for (int i = 0; i < numLives; i++) {
            livesIndicatorObjects[i].SetActive(true);
        }
        pool.SetActive(true);

        foreach(Transform obstacle in obstacleContainer.transform)
        {
            Destroy(obstacle.gameObject);
        }
        endScreenObject.SetActive(false);
    }

    public void EndGame() {
        pool.SetActive(false);
        endScreenObject.SetActive(true);
    }

    public void RemoveLife() {
        numLives--;
        
        if (numLives >= 0) {
            livesIndicatorObjects[numLives].SetActive(false);
        }

        if (numLives <= 0) { 
            EndGame();
        }
    }
}
