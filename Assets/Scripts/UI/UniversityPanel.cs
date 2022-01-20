using System;
using UnityEngine;
using UnityEngine.UI;

class UniversityPanel : MonoBehaviour
{
    private DateAndTime passedTime = new DateAndTime();
    //Использую, чтобы облегчить редактирование, после премещения какого-либо объекта
    private Transform Tiredness;
    private Transform Satiety;
    private Transform AcademicPerformance;
    private AcademicPerformance Study;

    public int gameGoal; 
        
    [Header("Button 1")]
    public string ToStudy1Name;
    public int ToStudy1Achievements;
    public int ToStudy1EnergyLoss;
    public int ToStudy1SatietyLoss;
    public double ToStudy1Duration; //in hours
    [Header("Button 2")]
    public string ToStudy2Name;
    public int ToStudy2Achievements;
    public int ToStudy2EnergyLoss;
    public int ToStudy2SatietyLoss;
    public double ToStudy2Duration; //in hours
    [Header("Button 3")]
    public string ToStudy3Name;
    public int ToStudy3Achievements;
    public int ToStudy3EnergyLoss;
    public int ToStudy3SatietyLoss;
    public double ToStudy3Duration; //in hours

    void Awake()
    {
        Tiredness = GameObject.Find("Tiredness").transform.Find("Points");
        Satiety = GameObject.Find("Satiety").transform.Find("Points");
        AcademicPerformance = GameObject.Find("AcademicPerformance").transform.Find("Points");

        Study = new AcademicPerformance(gameGoal);
        AcademicPerformance.GetComponent<Text>().text = Study.ToString();

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
        if (GameRules.RulesObserved(ToStudy1EnergyLoss, ToStudy1SatietyLoss) & !Study.IsWin())
        {
            Study.AddPoints(ToStudy1Achievements);
            AcademicPerformance.GetComponent<Text>().text = Study.ToString();
            Tiredness.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Tiredness.GetComponent<Text>().text) - ToStudy1EnergyLoss);
            Satiety.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Satiety.GetComponent<Text>().text) - ToStudy1SatietyLoss);
            passedTime.TimeWork(ToStudy1Duration);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToStudy2()
    {
        if (GameRules.RulesObserved(ToStudy2EnergyLoss, ToStudy2SatietyLoss) & !Study.IsWin())
        {
            Study.AddPoints(ToStudy2Achievements);
            AcademicPerformance.GetComponent<Text>().text = Study.ToString();
            Tiredness.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Tiredness.GetComponent<Text>().text) - ToStudy2EnergyLoss);
            Satiety.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Satiety.GetComponent<Text>().text) - ToStudy2SatietyLoss);
            passedTime.TimeWork(ToStudy2Duration);
        }
        else GameRules.EndOfGame();
    }
    public void ClickingOn_ToStudy3()
    {

        if (GameRules.RulesObserved(ToStudy3EnergyLoss, ToStudy3SatietyLoss) & !Study.IsWin())
        {
            Study.AddPoints(ToStudy3Achievements);
            AcademicPerformance.GetComponent<Text>().text = Study.ToString();
            Tiredness.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Tiredness.GetComponent<Text>().text) - ToStudy3EnergyLoss);
            Satiety.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(Satiety.GetComponent<Text>().text) - ToStudy3SatietyLoss);
            passedTime.TimeWork(ToStudy3Duration);
        }
        else GameRules.EndOfGame();
    }
}