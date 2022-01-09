using System;
using UnityEngine;
using UnityEngine.UI;

class HostelPanel : MonoBehaviour
{
    public void ClickingOn_ToSleep()
    {
        GameObject.Find("Tiredness").GetComponent<Text>().text = "100";
        DateAndTime.TimeWork(8);
    }
    public void ClickingOn_ToEat1()
    {
        if (GameRules.NoDebt(20))
        {
            if (Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 10 > 100)
            {
                GameObject.Find("Satiety").GetComponent<Text>().text = "100";
            }
            else
            {
                GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 20);
                GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 10);
            }
        }
        //else GameRules.EndOfGame();
    }
    public void ClickingOn_ToEat2()
    {
        if (GameRules.NoDebt(200))
        {
            if (Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 50 > 100)
            {
                GameObject.Find("Satiety").GetComponent<Text>().text = "100";
            }
            else
            {
                GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 200);
                GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 50);
            }
        }
        //else GameRules.EndOfGame();
    }
    public void ClickingOn_ToEat3()
    {
        if (GameRules.NoDebt(1000))
        {
            if (Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 80 > 100)
            {
                GameObject.Find("Satiety").GetComponent<Text>().text = "100";
            }
            else
            {
                GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 1000);
                GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 80);
            }
        }
        //else GameRules.EndOfGame();
    }
}

