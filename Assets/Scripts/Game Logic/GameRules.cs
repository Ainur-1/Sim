using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameRules : MonoBehaviour
{
    public static bool RulesObserved(int energyLoss, int satietyLoss)
    { 
        if ((Convert.ToInt32(GameObject.Find("Tiredness").transform.Find("Points").GetComponent<Text>().text) - energyLoss < 0) 
            | (Convert.ToInt32(GameObject.Find("Satiety").transform.Find("Points").GetComponent<Text>().text) - satietyLoss < 0))
            return false;
        else return true;
    }
    public static bool NoDebt(int withdrawal)
    {
        if (Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽')) - withdrawal < 0)
            return false;
        else return true;
    }
    public static bool OnceTouched(GameObject gameObject)
    {
        if (gameObject.GetComponentInChildren<Text>().text == "Куплено") return false;
        else return true;
    }
    public static void EndOfGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
