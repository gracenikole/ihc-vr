using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeInput : MonoBehaviour
{
    public InputField habit;
    public InputField time;

    public GameObject[] canvas;

    public void GetDataFromInput()
    {
        string Habit = habit.text;
        string Time = habit.time;
         
        Debug.Log("Datos del habit: " + Habit);
        Debug.Log("Datos del time: " + Time);
    }
}
