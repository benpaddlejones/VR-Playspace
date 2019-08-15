using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PrefabToSpawn;
    public Vector3 SpawnPosition;
    public void SpawnPrefab()
    {
        var spawnedPrefab = Instantiate(PrefabToSpawn);
        spawnedPrefab.transform.position += SpawnPosition;
    }
}
