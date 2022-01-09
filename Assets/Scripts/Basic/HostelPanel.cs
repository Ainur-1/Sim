using System;
using UnityEngine;
using UnityEngine.UI;

class HostelPanel : MonoBehaviour
{
    public void ClickingOn_ToSleep()
    {
        GameObject.Find("Tiredness").GetComponent<Text>().text = "100";
    }
    public void ClickingOn_ToEat()
    {
        GameObject.Find("Satiety").GetComponent<Text>().text = "100";
    }
}
