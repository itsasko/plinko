using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    void Start()
    {
        
    }

    public void ButttonPressed()
    {
        scoreText.text = "0";
    }
}
