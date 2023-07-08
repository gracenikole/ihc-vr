using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTree : MonoBehaviour
{
    public GameObject plantedTree;
    public GameObject Canvas;
    public GameObject Timer;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("UnplantedTree"))
        {
            plantedTree.SetActive(true);
            Canvas.SetActive(true);
            Timer.SetActive(true);
        }
    }
}
