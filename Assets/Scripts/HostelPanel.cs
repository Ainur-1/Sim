using System;
using UnityEngine;
using UnityEngine.UI;

class HostelPanel : MonoBehaviour
{
    private DateAndTime passedTime = new DateAndTime();

    public void ClickingOn_ToSleep()
    {
        GameObject.Find("Tiredness").GetComponent<Text>().text = "100";
        passedTime.TimeWork(8,0);
    }
    public void ClickingOn_ToEat1()
    {
        if (GameRules.NoDebt(20) & Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) != 100)
        {
            if (Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 10 > 100)
            {
                GameObject.Find("Satiety").GetComponent<Text>().text = "100";
                passedTime.TimeWork(0,20);
            }
            else
            {
                GameObject.Find("Money").GetComponent<Text>().text = '$' + 
                    Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 20);
                GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 10);
                passedTime.TimeWork(0, 20);
            }
        }
        //else GameRules.EndOfGame();
    }
    public void ClickingOn_ToEat2()
    {
        if (GameRules.NoDebt(200) & Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) != 100)
        {
            if (Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 50 > 100)
            {
                GameObject.Find("Satiety").GetComponent<Text>().text = "100";
                passedTime.TimeWork(0, 20);
            }
            else
            {
                GameObject.Find("Money").GetComponent<Text>().text = '$' + 
                    Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 200);
                GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 50);
                passedTime.TimeWork(0, 20);
            }
        }
        //else GameRules.EndOfGame();
    }
    public void ClickingOn_ToEat3()
    {
        if (GameRules.NoDebt(1000) & Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) != 100)
        {
            if (Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 80 > 100)
            {
                GameObject.Find("Satiety").GetComponent<Text>().text = "100";
                passedTime.TimeWork(0, 20);
            }
            else
            {
                GameObject.Find("Money").GetComponent<Text>().text = '$' + 
                    Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 1000);
                GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + 80);
                passedTime.TimeWork(0, 20);
            }
        }
        //else GameRules.EndOfGame();
    }
}

