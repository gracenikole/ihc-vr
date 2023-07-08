using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class setHabitTitle : MonoBehaviour
{
    public TMP_Text titleText;
    public TMP_InputField titleInput;

    public void setTitle() {
        titleText.text = titleInput.text.ToString();
    }
    
}
