using System;
using UnityEngine;
using UnityEngine.UI;

class HostelPanel : MonoBehaviour
{
    private DateAndTime passedTime = new DateAndTime();

    public string ToEat1Name;
    public int ToEat1Cost;
    public int ToEat1Satiety;
    public int ToEat1Duration; //in minutes

    public string ToEat2Name;
    public int ToEat2Cost;
    public int ToEat2Satiety;
    public int ToEat2Duration; //in minutes

    public string ToEat3Name;
    public int ToEat3Cost;
    public int ToEat3Satiety;
    public int ToEat3Duration; //in minutes

    void Awake()
    {
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
        if (GameObject.Find("Tiredness").GetComponent<Text>().text != "100")
        {
            GameObject.Find("Tiredness").GetComponent<Text>().text = "100";
            passedTime.TimeWork(8);
        }
    }
    public void ClickingOn_ToEat1()
    {
        if (GameRules.NoDebt(ToEat1Cost) & Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) != 100)
        {
            if (Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + ToEat1Satiety > 100)
            {
                GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽'))
                - ToEat1Cost) + "₽";
                GameObject.Find("Satiety").GetComponent<Text>().text = "100";
                passedTime.TimeWork(ToEat1Duration);
            }
            else
            {
                GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽'))
                - ToEat1Cost) + "₽";
                GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + ToEat1Satiety);
                passedTime.TimeWork(ToEat1Duration);
            }
        }
    }
    public void ClickingOn_ToEat2()
    {
        if (GameRules.NoDebt(ToEat2Cost) & Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) != 100)
        {
            if (Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + ToEat2Satiety > 100)
            {
                GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽'))
                - ToEat2Cost) + "₽";
                GameObject.Find("Satiety").GetComponent<Text>().text = "100";
                passedTime.TimeWork(ToEat2Duration);
            }
            else
            {
                GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽'))
                 - ToEat2Cost) + "₽";
                GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + ToEat2Satiety);
                passedTime.TimeWork(ToEat2Duration);
            }
        }
    }
    public void ClickingOn_ToEat3()
    {
        if (GameRules.NoDebt(ToEat3Cost) & Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) != 100)
        {
            if (Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + ToEat3Satiety > 100)
            {
                GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽'))
                - ToEat3Cost) + "₽";
                GameObject.Find("Satiety").GetComponent<Text>().text = "100";
                passedTime.TimeWork(ToEat3Duration);
            }
            else
            {
                GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽'))
                - ToEat3Cost) + "₽";
                GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) + ToEat3Satiety);
                passedTime.TimeWork(ToEat3Duration);
            }
        }
    }
}

