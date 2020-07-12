using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabFactory : MonoBehaviour
{

    public void SpawnPrefabInFront(string prefabName)
    {
        SpawnPrefabInFront(prefabName, 1f);
    }


    public void SpawnPrefabInFront(string prefabName, float spawnDistance)
    {
        Instantiate(Resources.Load(prefabName), transform.position + (transform.up * spawnDistance), transform.rotation);
    }


    public void SpawnPrefabInFront(string prefabName, float spawnDistance, Quaternion spawnRotation)
    {
        Instantiate(Resources.Load(prefabName), transform.position + (transform.up * spawnDistance), spawnRotation);
    }


    public void SpawnPrefabAtLocation(string prefabName, Vector3 spawnLocation)
    {
        SpawnPrefabAtLocation(prefabName, spawnLocation, new Quaternion(0,0,0,0));
    }


    public void SpawnPrefabAtLocation(string prefabName, Vector3 spawnLocation, Quaternion spawnRotation)
    {
        Instantiate(Resources.Load(prefabName), spawnLocation, spawnRotation);
    }
}
