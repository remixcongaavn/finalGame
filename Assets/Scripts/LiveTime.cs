using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveTime : MonoBehaviour
{
    public static int lastPlayLive = 1;

    public Dropdown liveDropDown;

    public Slider timeSlider;

    public Text second;


    public void changeLives()
    {
        switch (liveDropDown.value)
        {
            default:
                lastPlayLive = 3;
                break;

            case 0:
                lastPlayLive = 3;
                break;

            case 1:
                lastPlayLive = 6;
                break;

            case 2:
                lastPlayLive = 9;
                break;
        }
    }

    public void timeUpdate(float value)
    {
        TimeCountDown.timeLeft = timeSlider.value;
        second.text = timeSlider.value.ToString("0");
    }
}
