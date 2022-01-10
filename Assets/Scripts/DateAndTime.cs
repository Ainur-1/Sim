using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateAndTime : MonoBehaviour
{
    DateTime timeInGame = new DateTime(2022,9,1,8,0,0);
    
    void Start()
    {
        GameObject.Find("Time").GetComponent<Text>().text = String.Format($"{1}:{2}", timeInGame.Hour, timeInGame.Minute);
    }
    //public static void TimeWork( int timeOfAction)
    //{
    //    List<int> now = new List<int>();
    //    foreach (string i in GameObject.Find("Time").GetComponent<Text>().text.Split(':'))
    //        now.Add(Convert.ToInt32(i));
    //    GameObject.Find("Time").GetComponent<Text>().text = String.Format($"{1}:{2}", now[0]+timeOfAction, now[1]);
    //} 
}
