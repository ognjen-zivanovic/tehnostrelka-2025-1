using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class KurtCobain : MonoBehaviour
{
    public void KillYourself() {
        Destroy(gameObject);
    }

    public void SetSpawnIndex(int index) {
        ObjectSpawner.numSpawnedThings = 0;
        ObjectSpawner.m_SpawnOptionIndex = index;
    }
}
