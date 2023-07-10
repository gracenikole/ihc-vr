using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject treePrefab;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            //Instantiate(cubePrefab, transform.position, Quaternion.identity);
            Instantiate(treePrefab, transform.position, Quaternion.identity);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        
    }
}
