using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public int difficulty;
    public int sleepHours;

    bool RulesObserved()
    {
        if((Convert.ToInt32(GameObject.Find("S_E").GetComponent<Text>().text) < 0) | (Convert.ToInt32(GameObject.Find("S_S").GetComponent<Text>().text) < 0))
            return false;
        else return true;
    }

    public void ClickingOn_Eat()
    {
        if (RulesObserved() == true)
        {
            if (Convert.ToInt32(GameObject.Find("S_E").GetComponent<Text>().text) + difficulty <= 100)
            {
                GameObject.Find("S_E").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("S_E").GetComponent<Text>().text) + difficulty);
                GameObject.Find("S_S").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("S_S").GetComponent<Text>().text) - difficulty);
            }
        }
        else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void ClickingOn_Study()
    {
        if (RulesObserved() == true)
        {
            if (Convert.ToInt32(GameObject.Find("S_St").GetComponent<Text>().text) < 500)
            {
                GameObject.Find("S_E").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("S_E").GetComponent<Text>().text) - difficulty);
                GameObject.Find("S_S").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("S_S").GetComponent<Text>().text) - difficulty);
                GameObject.Find("S_St").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("S_St").GetComponent<Text>().text) + difficulty);
            }
            else SceneManager.LoadScene("BAsic", LoadSceneMode.Single);
        }
        else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void ClickingOn_Sleep()
    {
        if (RulesObserved() == true)
        {
            if (Convert.ToInt32(GameObject.Find("S_S").GetComponent<Text>().text) + difficulty * sleepHours <= 100)
            {
                GameObject.Find("S_E").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("S_E").GetComponent<Text>().text) - difficulty);
                GameObject.Find("S_S").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("S_S").GetComponent<Text>().text) + difficulty * sleepHours);
            }
        }
        else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
