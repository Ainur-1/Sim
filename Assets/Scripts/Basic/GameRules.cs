using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameRules : MonoBehaviour
{
    public static bool RulesObserved()
    { 
        if ((Convert.ToInt32(GameObject.Find("Tiredness").GetComponent<Text>().text) <= 0) | (Convert.ToInt32(GameObject.Find("Satiety").GetComponent<Text>().text) <= 0))
            return false;
        else return true;
    }
    public static void EndOfGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
