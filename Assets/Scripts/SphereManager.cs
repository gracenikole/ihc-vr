using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public GameObject spherePrefab; // Prefab of the sphere
    public Transform spawnPoint; // Point where spheres will be spawned
    public float spawnInterval = 1f; // Time interval between each sphere spawn
    public float spawnForce = 5f; // Initial force applied to the spawned sphere

    private void Start()
    {
        // Start spawning spheres
        StartCoroutine(SpawnSpheres());
    }

    private IEnumerator SpawnSpheres()
    {
        while (true)
        {
            // Instantiate a new sphere from the prefab at the spawn point
            GameObject newSphere = Instantiate(spherePrefab, spawnPoint.position, Quaternion.identity);
            newSphere.transform.SetParent(spawnPoint.parent);
            // Wait for the specified spawn interval
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
