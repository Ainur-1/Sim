using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DateAndTime : MonoBehaviour
{
    private static DateTime timeInGame;

    public void TimeWork(double hours)
    {
        timeInGame = timeInGame.AddHours(hours);
        GameObject.Find("Time").GetComponent<Text>().text = timeInGame.ToShortDateString() + '\n' + timeInGame.ToShortTimeString();
    }
    void Start()
    {
        timeInGame = new DateTime(2022, 9, 1, 8, 0, 0);
        GameObject.Find("Time").GetComponent<Text>().text = timeInGame.ToShortDateString() + '\n' + timeInGame.ToShortTimeString();
        StartCoroutine(Time—ount());
    }
    IEnumerator Time—ount()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(1);
            timeInGame = timeInGame.AddMinutes(1);
            GameObject.Find("Time").GetComponent<Text>().text = timeInGame.ToShortDateString() + '\n' + timeInGame.ToShortTimeString();
        }
    }
}