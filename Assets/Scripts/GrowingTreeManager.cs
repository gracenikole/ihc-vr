using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingTreeManager : MonoBehaviour
{

    public float maxSize;
    public float growRate;
    private float scale = 0.0f;
    public Color[] colorVariations;

    // Start is called before the first frame update
    void Start()
    {
        maxSize = Random.Range(0.0f, 2.0f); 
        growRate = Random.Range(0.2f, 0.8f);    
    }

    // Update is called once per frame
    void Update()
    {
        if (scale < maxSize)
        {
            transform.localScale = Vector3.one * scale;
            scale += growRate * Time.deltaTime;
        }
    }
}