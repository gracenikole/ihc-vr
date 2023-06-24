using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHabit : MonoBehaviour
{
    public Button btnClick;

    public InputField habit;
    public InputField time;

    public GameObject[] canvas;

    private void Start() {
        btnClick.onClick.AddListener(CreateHabit);
    }

    public void CreateHabit()
    {        
        Debug.Log("A: " + habit.text);
        // Debug.Log("A: " + time.text);
    }
}
