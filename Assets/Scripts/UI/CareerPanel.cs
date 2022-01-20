using System;
using UnityEngine;
using UnityEngine.UI;

class CareerPanel : MonoBehaviour
{
    private DateAndTime passedTime = new DateAndTime();
    //Использую, чтобы облегчить редактирование, после премещения какого-либо объекта
    private Transform Tiredness;
    private Transform Satiety;
    private GameObject Money;

    [Header("Button 1")]
    public string ToWork1Name;
    public int ToWork1Salary;
    public int ToWork1EnergyLoss;
    public int ToWork1SatietyLoss;
    public int ToWork1Duration; //in hours
    [Header("Button 2")]
    public string ToWork2Name;
    public int ToWork2Salary;
    public int ToWork2EnergyLoss;
    public int ToWork2SatietyLoss;
    public int ToWork2Duration; //in hours
    [Header("Button 3")]
    public string ToWork3Name;
    public int ToWork3Salary;
    public int ToWork3EnergyLoss;
    public int ToWork3SatietyLoss;
    public int ToWork3Duration; //in hours

    void Awake()
    {
        Tiredness = GameObject.Find("Tiredness").transform.Find("Points");
        Satiety = GameObject.Find("Satiety").transform.Find("Points");
        Money = GameObject.Find("Money");

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
            Money.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Money.GetComponent<Text>().text.TrimEnd('₽')) + ToWork1Salary) + "₽";
            Tiredness.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Tiredness.GetComponent<Text>().text) - ToWork1EnergyLoss);
            Satiety.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Satiety.GetComponent<Text>().text) - ToWork1SatietyLoss);
            passedTime.TimeWork(ToWork1Duration);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToWork2()
    {
        if (GameRules.RulesObserved(ToWork2EnergyLoss, ToWork2SatietyLoss))
        {
            Money.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Money.GetComponent<Text>().text.TrimEnd('₽')) + ToWork2Salary) + "₽";
            Tiredness.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Tiredness.GetComponent<Text>().text) - ToWork2EnergyLoss);
            Satiety.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Satiety.GetComponent<Text>().text) - ToWork2SatietyLoss);
            passedTime.TimeWork(ToWork2Duration);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToWork3()
    {
        if (GameRules.RulesObserved(ToWork3EnergyLoss, ToWork3SatietyLoss))
        {
            Money.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Money.GetComponent<Text>().text.TrimEnd('₽')) + ToWork3Salary) + "₽";
            Tiredness.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Tiredness.GetComponent<Text>().text) - ToWork3EnergyLoss);
            Satiety.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Satiety.GetComponent<Text>().text) - ToWork3SatietyLoss);
            passedTime.TimeWork(ToWork3Duration);
        }
        else GameRules.EndOfGame();
    }
}