using System;
using UnityEngine;
using UnityEngine.UI;

class CareerPanel : MonoBehaviour
{
    private DateAndTime passedTime = new DateAndTime();

    public void ClickingOn_ToWork1()
    {
        if (GameRules.RulesObserved(10, 10))
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) + 100);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - 10);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - 10);
            passedTime.TimeWork(4, 0);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToWork2()
    {
        if (GameRules.RulesObserved(20, 20))
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) + 200);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - 20);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - 20);
            passedTime.TimeWork(8, 0);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToWork3()
    {
        if (GameRules.RulesObserved(50, 50))
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) + 500);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - 50);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - 50);
            passedTime.TimeWork(12, 0);
        }
        else GameRules.EndOfGame();
    }
}