using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTree : MonoBehaviour
{
    public GameObject plantedTree;
    public GameObject canvas;
    public GameObject timer;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("UnplantedTree"))
        {
            plantedTree.SetActive(true);
            canvas.SetActive(true);
            timer.SetActive(true);
        }
    }
}
