using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public static int scoreUpdate;
    public Text scoreText;

    void Start()
    {
        scoreUpdate = 0;
        updateScoreUI();
    }
    public void addScore(int x)
    {
        scoreUpdate += 1;
        updateScoreUI();
    }

    public void ReduceScore(int y)
    {
        scoreUpdate -= 1;
        updateScoreUI();
    }

    void updateScoreUI()
    {
        scoreText.text = scoreUpdate.ToString();
    }

}
