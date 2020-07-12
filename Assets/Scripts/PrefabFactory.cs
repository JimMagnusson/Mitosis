using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabFactory : MonoBehaviour
{
    void SpawnPrefabInFront(string prefabName)
    {
        SpawnPrefabInFront(prefabName, 1f);
    }

    void SpawnPrefabInFront(string prefabName, float spawnDistance = 1f)
    {
        Instantiate(Resources.Load(prefabName), transform.position + (transform.up * spawnDistance), transform.rotation);
    }

    void SpawnPrefabAtLocation(string prefabName, Vector3 spawnLocation)
    {
        SpawnPrefabAtLocation(prefabName, spawnLocation, new Quaternion(0,0,0,0));
    }

    void SpawnPrefabAtLocation(string prefabName, Vector3 spawnLocation, Quaternion spawnRotation = default(Quaternion))
    {
        Instantiate(Resources.Load(prefabName), spawnLocation, spawnRotation);
    }
}
