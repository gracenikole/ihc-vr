using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTree : MonoBehaviour
{
    public GameObject PlantedTree;
    public GameObject Canvas;
    public GameObject Timer;
    public GameObject HabitTitle;

    private void OnCollisionEnter(Collision collision) {
        if(collision.collider.CompareTag("ShovelKiller")) {
            PlantedTree.SetActive(false);
            Canvas.SetActive(false);
            Timer.SetActive(false);
            HabitTitle.SetActive(false);
        }
    }

}
