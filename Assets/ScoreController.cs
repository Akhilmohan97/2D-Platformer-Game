using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{

    public TextMeshProUGUI Scoregui;
    int score = 0;

    public void IncreaseScore(int NewScore)
    {
        score += NewScore;
        Refreshscore();
    }
    public void Refreshscore()
    {
        Scoregui.text = "SCORE:"+score;
    }
}