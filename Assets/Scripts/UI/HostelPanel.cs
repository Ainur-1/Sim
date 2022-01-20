using System;
using UnityEngine;
using UnityEngine.UI;

class HostelPanel : MonoBehaviour
{
    private DateAndTime passedTime = new DateAndTime();
    //Использую, чтобы облегчить редактирование, после премещения какого-либо объекта
    private Transform Tiredness;
    private Transform Satiety;
    private GameObject Money;

    [Header("Button 1")]
    public string ToEat1Name;
    public int ToEat1Cost;
    public int ToEat1Satiety;
    public int ToEat1Duration; //in minutes
    [Header("Button 2")]
    public string ToEat2Name;
    public int ToEat2Cost;
    public int ToEat2Satiety;
    public int ToEat2Duration; //in minutes
    [Header("Button 3")]
    public string ToEat3Name;
    public int ToEat3Cost;
    public int ToEat3Satiety;
    public int ToEat3Duration; //in minutes

    void Awake()
    {
        Tiredness = GameObject.Find("Tiredness").transform.Find("Points");
        Satiety = GameObject.Find("Satiety").transform.Find("Points");
        Money = GameObject.Find("Money");

        GameObject.Find("To Eat #1").GetComponentInChildren<Text>().text = GameObject.Find("Hostel Panel").GetComponent<HostelPanel>().ToEat1Name + "  " +
            Convert.ToString(GameObject.Find("Hostel Panel").GetComponent<HostelPanel>().ToEat1Satiety) + "/" +
            Convert.ToString(GameObject.Find("Hostel Panel").GetComponent<HostelPanel>().ToEat1Cost) + "₽";
        GameObject.Find("To Eat #2").GetComponentInChildren<Text>().text = GameObject.Find("Hostel Panel").GetComponent<HostelPanel>().ToEat2Name + "  " +
            Convert.ToString(GameObject.Find("Hostel Panel").GetComponent<HostelPanel>().ToEat2Satiety) + "/" +
            Convert.ToString(GameObject.Find("Hostel Panel").GetComponent<HostelPanel>().ToEat2Cost) + "₽";
        GameObject.Find("To Eat #3").GetComponentInChildren<Text>().text = GameObject.Find("Hostel Panel").GetComponent<HostelPanel>().ToEat3Name + "  " +
            Convert.ToString(GameObject.Find("Hostel Panel").GetComponent<HostelPanel>().ToEat3Satiety) + "/" +
            Convert.ToString(GameObject.Find("Hostel Panel").GetComponent<HostelPanel>().ToEat3Cost) + "₽";
    }
    public void ClickingOn_ToSleep()
    {
        if (Tiredness.GetComponent<Text>().text != "100")
        {
            Tiredness.GetComponent<Text>().text = "100";
            passedTime.TimeWork(8);
        }
    }
    public void ClickingOn_ToEat1()
    {
        if (GameRules.NoDebt(ToEat1Cost) & Convert.ToInt32(Satiety.GetComponent<Text>().text) != 100)
        {
            if (Convert.ToInt32(Satiety.GetComponent<Text>().text) + ToEat1Satiety > 100)
            {
                Money.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Money.GetComponent<Text>().text.TrimEnd('₽'))
                - ToEat1Cost) + "₽";
                Satiety.GetComponent<Text>().text = "100";
                passedTime.TimeWork(ToEat1Duration);
            }
            else
            {
                Money.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Money.GetComponent<Text>().text.TrimEnd('₽'))
                - ToEat1Cost) + "₽";
                Satiety.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Satiety.GetComponent<Text>().text) + ToEat1Satiety);
                passedTime.TimeWork(ToEat1Duration);
            }
        }
    }
    public void ClickingOn_ToEat2()
    {
        if (GameRules.NoDebt(ToEat2Cost) & Convert.ToInt32(Satiety.GetComponent<Text>().text) != 100)
        {
            if (Convert.ToInt32(Satiety.GetComponent<Text>().text) + ToEat2Satiety > 100)
            {
                Money.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Money.GetComponent<Text>().text.TrimEnd('₽'))
                - ToEat2Cost) + "₽";
                Satiety.GetComponent<Text>().text = "100";
                passedTime.TimeWork(ToEat2Duration);
            }
            else
            {
                Money.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Money.GetComponent<Text>().text.TrimEnd('₽'))
                 - ToEat2Cost) + "₽";
                Satiety.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Satiety.GetComponent<Text>().text) + ToEat2Satiety);
                passedTime.TimeWork(ToEat2Duration);
            }
        }
    }
    public void ClickingOn_ToEat3()
    {
        if (GameRules.NoDebt(ToEat3Cost) & Convert.ToInt32(Satiety.GetComponent<Text>().text) != 100)
        {
            if (Convert.ToInt32(Satiety.GetComponent<Text>().text) + ToEat3Satiety > 100)
            {
                Money.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Money.GetComponent<Text>().text.TrimEnd('₽'))
                - ToEat3Cost) + "₽";
                Satiety.GetComponent<Text>().text = "100";
                passedTime.TimeWork(ToEat3Duration);
            }
            else
            {
                Money.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Money.GetComponent<Text>().text.TrimEnd('₽'))
                - ToEat3Cost) + "₽";
                Satiety.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Satiety.GetComponent<Text>().text) + ToEat3Satiety);
                passedTime.TimeWork(ToEat3Duration);
            }
        }
    }
}

