using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountDown : MonoBehaviour
{
    public Text timeDisplay;
    public static float timeLeft = 60;
    private bool takingAway = false;

    void Start()
    {
        timeDisplay.text = "00:" + timeLeft;
    }

    void Update()
    {
        if (takingAway == false && timeLeft > 0)
        {
            StartCoroutine(TimeTake());
        }
    }

    IEnumerator TimeTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        timeLeft -= 1;

        if (timeLeft < 10)
        {
            timeDisplay.text = "00:0" + timeLeft;
        }
        else
        {
            timeDisplay.text = "00:" + timeLeft;
        }

        takingAway = false;
    }
}
