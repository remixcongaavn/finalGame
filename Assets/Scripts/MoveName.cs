using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveName : MonoBehaviour
{
    public Text displayName;
    public Text displayLive;
    public Text displayScore;

    public void Start()
    {
        displayName.text = "Name: " + NameTransfer.theName;

    }

    void Update()
    {
        displayLive.text = "Lives: " + LivesButton.liveUpdate.ToString();

        displayScore.text = "Score: " + ScoreButton.scoreUpdate.ToString();
    }
}
