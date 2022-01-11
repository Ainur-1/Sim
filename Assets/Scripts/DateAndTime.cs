using System;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class DateAndTime : MonoBehaviour
{
    private static DateTime timeInGame;

    public void TimeWork(int hours, int minutes)
    {
        timeInGame = timeInGame.AddHours(hours);
        timeInGame = timeInGame.AddMinutes(minutes);
        GameObject.Find("Time").GetComponent<Text>().text = timeInGame.ToShortDateString() + '\n' + timeInGame.ToShortTimeString();
    }
    void Start()
    {
        timeInGame = new DateTime(2022, 9, 1, 8, 0, 0);
        GameObject.Find("Time").GetComponent<Text>().text = timeInGame.ToShortDateString() + '\n' + timeInGame.ToShortTimeString();
    }
    //private void FixedUpdate()
    //{
    //    for (; ; )
    //    {
    //        Thread.Sleep(1000);
    //        timeInGame = timeInGame.AddMinutes(1);
    //    }
    //}
}