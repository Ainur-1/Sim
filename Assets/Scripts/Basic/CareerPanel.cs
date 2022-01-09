using System;
using UnityEngine;
using UnityEngine.UI;

class CareerPanel : MonoBehaviour
{
    public void ClickingOn_ToWork1()
    {
        if (GameRules.RulesObserved())
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) + 100);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - 10);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - 10);

        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToWork2()
    {
        if (GameRules.RulesObserved())
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) + 200);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - 20);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - 20);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToWork3()
    {
        if (GameRules.RulesObserved())
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) + 500);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - 50);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - 50);
        }
        else GameRules.EndOfGame();
    }
}