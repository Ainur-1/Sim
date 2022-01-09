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
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 20);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 10);
        }
        //else GameRules.EndOfGame();
    }
    public void ClickingOn_ToEat2()
    {
        if (GameRules.NoDebt(200))
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 200);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 50);
        }
        //else GameRules.EndOfGame();
    }
    public void ClickingOn_ToEat3()
    {
        if (GameRules.NoDebt(1000))
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 1000);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 80);

        }
        //else GameRules.EndOfGame();
    }
}

