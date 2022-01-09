using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateAndTime : MonoBehaviour
{
    public static void TimeWork( int timeOfAction)
    {
        List<int> now = new List<int>();
        foreach (string i in GameObject.Find("Time").GetComponent<Text>().text.Split(':'))
            now.Add(Convert.ToInt32(i));
        GameObject.Find("Time").GetComponent<Text>().text = String.Format($"{1}:{2}", now[0]+timeOfAction, now[1]);
    } 
}
