using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCanvas : MonoBehaviour
{
    public TMP_Text timerText;
    public int minutes = 2;
    public int seconds = 30;

    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        while (minutes >= 0 && seconds >= 0)
        {
            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

            yield return new WaitForSeconds(1);

            if (seconds == 0)
            {
                if (minutes == 0)
                {
                    // Countdown has finished
                    Debug.Log("Countdown Finished");
                    break;
                }
                else
                {
                    minutes--;
                    seconds = 59;
                }
            }
            else
            {
                seconds--;
            }
        }
    }
}
