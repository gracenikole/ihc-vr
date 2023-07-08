using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimerController : MonoBehaviour
{
    public TMP_Text timerText;
    public TMP_InputField min_, seg_;
    private int min, seg;
    public Button setHabitButton;
    private float rest;
    private bool isRunning;

    private void Awake()
    {
        isRunning = false;
        setHabitButton.onClick.AddListener(() => setTimes(min_, seg_));
    }

    void setTimes(TMP_InputField min_, TMP_InputField seg_) {
        int.TryParse(min_.text.ToString(), out min);
        int.TryParse(seg_.text.ToString(), out seg);

        rest = (min * 60) + seg;
        isRunning = true;   
    }

    void OnDisable() {
        setHabitButton.onClick.RemoveAllListeners();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            rest -= Time.deltaTime;
            if(rest < 1)
            {
                isRunning = false;
                // plantTree.DowngradePlant();
            }
            int tempMin = Mathf.FloorToInt(rest / 60);
            int tempSeg = Mathf.FloorToInt(rest % 60);
            timerText.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }  
    }
}
