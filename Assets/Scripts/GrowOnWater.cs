using UnityEngine;

public class GrowOnWater : MonoBehaviour
{
    // Set this in the Unity editor to define how much the object grows when hit by a particle
    public float growthIncrement = 0.01f;

    // Set these in the Unity editor to specify the different stages of growth
    public GameObject[] growthStages;
    public GameObject Canvas;
    public GameObject Timer;

    // Keep track of the current size
    private int currentStage = 0;
    private int maxWater = 3;
    private int currentWater = 0;
    private bool planted = false;
    // Ensure the initial prefab is set correctly
    private void Start()
    {
        SetStage(0);
        Canvas.SetActive(true);
        Timer.SetActive(true);
    }

    // private void OnParticleCollision(GameObject other)
    // {
    //     Debug.Log("Particle Collision Detected with " + other.name);
    //     // Check if the colliding particles are from the water system
    //     if (other.CompareTag("WaterCollisionSystem")) // Replace with your water particle system's name
    //     {
    //         // Grow the object
    //         transform.localScale += new Vector3(growthIncrement, growthIncrement, growthIncrement);

    //         // If the object has grown enough, advance to the next growth stage
    //         if (transform.localScale.x > (currentStage + 1) * 0.5f && currentStage < growthStages.Length - 1) // Replace 0.5f with your growth threshold
    //         {
    //             currentStage++;
    //             SetStage(currentStage);
    //         }
    //     }
    // }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WaterParticleSystem"))
        {
            if(growthStages[currentStage].activeSelf == true)
            {
                // Grow the object
                Debug.Log("watering");
                currentWater += 1;

                // If the object has grown enough, advance to the next growth stage
                if (currentWater >= maxWater && currentStage < growthStages.Length - 1) // Replace 0.5f with your growth threshold
                {
                    currentWater = 0;
                    currentStage++;
                    SetStage(currentStage);
                }
            }
        }
    }   


    private void SetStage(int stage)
    {
        // Hide all stages
        foreach (GameObject stageObject in growthStages)
        {
            stageObject.SetActive(false);
        }

        // Show the current stage
        growthStages[stage].SetActive(true);
    }
}
