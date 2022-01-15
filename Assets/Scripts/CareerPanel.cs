using System;
using UnityEngine;
using UnityEngine.UI;

class CareerPanel : MonoBehaviour
{
    private DateAndTime passedTime = new DateAndTime();

    public string ToWork1Name;
    public int ToWork1Salary;
    public int ToWork1EnergyLoss;
    public int ToWork1SatietyLoss;
    public int ToWork1Duration; //in hours

    public string ToWork2Name;
    public int ToWork2Salary;
    public int ToWork2EnergyLoss;
    public int ToWork2SatietyLoss;
    public int ToWork2Duration; //in hours


    public string ToWork3Name;
    public int ToWork3Salary;
    public int ToWork3EnergyLoss;
    public int ToWork3SatietyLoss;
    public int ToWork3Duration; //in hours

    void Awake()
    {
        GameObject.Find("To Work #1").GetComponentInChildren<Text>().text = GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork1Name + "  " +
            Convert.ToString(GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork1SatietyLoss) + "/" +
            Convert.ToString(GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork1EnergyLoss) + "/" +
            Convert.ToString(GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork1Salary) + "₽";
        GameObject.Find("To Work #2").GetComponentInChildren<Text>().text = GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork2Name + "  " +
            Convert.ToString(GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork2SatietyLoss) + "/" +
            Convert.ToString(GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork2EnergyLoss) + "/" +
            Convert.ToString(GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork2Salary) + "₽";
        GameObject.Find("To Work #3").GetComponentInChildren<Text>().text = GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork3Name + "  " +
           Convert.ToString(GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork3SatietyLoss) + "/" +
           Convert.ToString(GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork3EnergyLoss) + "/" +
           Convert.ToString(GameObject.Find("Career Panel").GetComponent<CareerPanel>().ToWork3Salary) + "₽";
    }                                                                                         
    public void ClickingOn_ToWork1()
    {
        if (GameRules.RulesObserved(ToWork1EnergyLoss, ToWork1SatietyLoss))
        {
            GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽'))
                + ToWork1Salary) + "₽";
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - ToWork1EnergyLoss);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - ToWork1SatietyLoss);
            passedTime.TimeWork(ToWork1Duration);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToWork2()
    {
        if (GameRules.RulesObserved(ToWork2EnergyLoss, ToWork2SatietyLoss))
        {
            GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽'))
                + ToWork2Salary) + "₽";
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - ToWork2EnergyLoss);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - ToWork2SatietyLoss);
            passedTime.TimeWork(ToWork2Duration);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToWork3()
    {
        if (GameRules.RulesObserved(ToWork3EnergyLoss, ToWork3SatietyLoss))
        {
            GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽'))
                + ToWork3Salary) + "₽";
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - ToWork3EnergyLoss);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - ToWork3SatietyLoss);
            passedTime.TimeWork(ToWork3Duration);
        }
        else GameRules.EndOfGame();
    }
}