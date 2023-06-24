using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingTreeManager : MonoBehaviour
{

    public float maxSize;
    public float growRate;
    private float scale = 0.0f;
    public Color[] colorVariations;
    private bool shouldGrow = false;

    // Start is called before the first frame update
    void Start()
    {
        maxSize = Random.Range(100.0f, 200.0f); 
        growRate = Random.Range(2.0f, 8.0f);    
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldGrow && scale < maxSize)
        {
            transform.localScale = Vector3.one * scale;
            scale += growRate * Time.deltaTime;
        }
    }

    public void ToggleGrow()
    {
        shouldGrow = !shouldGrow;
    }
}