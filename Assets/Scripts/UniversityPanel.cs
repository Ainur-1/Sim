using System;
using UnityEngine;
using UnityEngine.UI;

class UniversityPanel : MonoBehaviour
{
    private DateAndTime passedTime = new DateAndTime();

    public string ToStudy1Name;
    public int ToStudy1Achievements;
    public int ToStudy1EnergyLoss;
    public int ToStudy1SatietyLoss;
    public double ToStudy1Duration; //in hours

    public string ToStudy2Name;
    public int ToStudy2Achievements;
    public int ToStudy2EnergyLoss;
    public int ToStudy2SatietyLoss;
    public double ToStudy2Duration; //in hours

    public string ToStudy3Name;
    public int ToStudy3Achievements;
    public int ToStudy3EnergyLoss;
    public int ToStudy3SatietyLoss;
    public double ToStudy3Duration; //in hours

    void Awake()
    {
        GameObject.Find("To Study #1").GetComponentInChildren<Text>().text = GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy1Name + "  +" +
            Convert.ToString(GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy1Achievements) + "/" +
            Convert.ToString(GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy1SatietyLoss) + "/" +
            Convert.ToString(GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy1EnergyLoss);
        GameObject.Find("To Study #2").GetComponentInChildren<Text>().text = GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy2Name + "  +" +
            Convert.ToString(GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy2Achievements) + "/" +
            Convert.ToString(GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy2SatietyLoss) + "/" +
            Convert.ToString(GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy2EnergyLoss);
        GameObject.Find("To Study #3").GetComponentInChildren<Text>().text = GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy3Name + "  +" +
            Convert.ToString(GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy3Achievements) + "/" +
            Convert.ToString(GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy3SatietyLoss) + "/" +
            Convert.ToString(GameObject.Find("University Panel").GetComponent<UniversityPanel>().ToStudy3EnergyLoss);
    }
    public void ClickingOn_ToStudy1()
    {
        if (GameRules.RulesObserved(ToStudy1EnergyLoss, ToStudy1SatietyLoss))
        {
            GameObject.Find("AcademicPerformance").GetComponent<Text>().text =
                Convert.ToString(Convert.ToInt32(GameObject.Find("AcademicPerformance").GetComponent<Text>().text) + ToStudy1Achievements);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - ToStudy1EnergyLoss);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - ToStudy1SatietyLoss);
            passedTime.TimeWork(ToStudy1Duration);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToStudy2()
    {
        if (GameRules.RulesObserved(ToStudy2EnergyLoss, ToStudy2SatietyLoss))
        {
            GameObject.Find("AcademicPerformance").GetComponent<Text>().text =
                Convert.ToString(Convert.ToInt32(GameObject.Find("AcademicPerformance").GetComponent<Text>().text) + ToStudy2Achievements);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - ToStudy2EnergyLoss);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - ToStudy2SatietyLoss);
            passedTime.TimeWork(ToStudy2Duration);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToStudy3()
    {

        if (GameRules.RulesObserved(ToStudy3EnergyLoss, ToStudy3SatietyLoss))
        {
            GameObject.Find("AcademicPerformance").GetComponent<Text>().text =
                Convert.ToString(Convert.ToInt32(GameObject.Find("AcademicPerformance").GetComponent<Text>().text) + ToStudy3Achievements);
            GameObject.Find("Tiredness").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) - ToStudy3EnergyLoss);
            GameObject.Find("Satiety").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) - ToStudy3SatietyLoss);
            passedTime.TimeWork(ToStudy3Duration);
        }
        else GameRules.EndOfGame();
    }
}