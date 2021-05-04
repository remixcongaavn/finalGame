using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesButton : MonoBehaviour
{
    public static int liveUpdate;
    public Text liveText;

    void Start()
    {
        liveUpdate = 0;
        updateScoreUI();
    }
    public void addLive(int x)
    {
        liveUpdate += 1;
        updateScoreUI();
    }

    public void ReduceLive(int y)
    {
        liveUpdate -= 1;
        updateScoreUI();
    }

    void updateScoreUI()
    {
        liveText.text = liveUpdate.ToString();
    }
}
