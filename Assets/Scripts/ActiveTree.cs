using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTree : MonoBehaviour
{
    public GameObject plantedTree;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("UnplantedTree"))
        {
            plantedTree.SetActive(true);
        }
    }
}
