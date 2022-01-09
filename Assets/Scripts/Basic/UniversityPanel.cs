using System;
using UnityEngine;
using UnityEngine.UI;

class UniversityPanel : MonoBehaviour
{
    public void ClickingOn_ToStudy1()
    {
        if (GameRules.RulesObserved())
        {
            GameObject.Find("AcademicPerformance").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("AcademicPerformance").GetComponent<Text>().text) + 10);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - 10);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - 10);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToStudy2()
    {
        if (GameRules.RulesObserved())
        {
            GameObject.Find("AcademicPerformance").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("AcademicPerformance").GetComponent<Text>().text) + 20);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - 10);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - 10);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToStudy3()
    {

        if (GameRules.RulesObserved())
        {
            GameObject.Find("AcademicPerformance").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("AcademicPerformance").GetComponent<Text>().text) + 50);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - 10);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - 10);
        }
        else GameRules.EndOfGame();
    }
}