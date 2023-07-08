using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNewTree : MonoBehaviour
{
   public GameObject prefabToGenerate;

    public void Generate() {
        float customPositionX = 0.00999999F;
        float customPositionY = 1.57F;
        float customPositionZ = -0.201F;
        Vector3 customPosition = new Vector3(customPositionX, customPositionY, customPositionZ);
        Instantiate(prefabToGenerate, customPosition, transform.rotation);
    }
}
