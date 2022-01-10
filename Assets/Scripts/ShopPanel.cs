using System;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanel : MonoBehaviour
{
    public void ClickingOn_Product1()
    {
        if (GameRules.NoDebt(200) & GameRules.OnceTouched(GameObject.Find("Product #1")))
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 200);
            GameObject.Find("Product #1").GetComponentInChildren<Text>().text = "Куплено";
        }
    }
    public void ClickingOn_Product2()
    {
        if (GameRules.NoDebt(500) & GameRules.OnceTouched(GameObject.Find("Product #2")))
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 500);
            GameObject.Find("Product #2").GetComponentInChildren<Text>().text = "Куплено";
        }
    }
    public void ClickingOn_Product3()
    {
        if (GameRules.NoDebt(1000) & GameRules.OnceTouched(GameObject.Find("Product #3")))
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 1000);
            GameObject.Find("Product #3").GetComponentInChildren<Text>().text = "Куплено";
        }
    }
    public void ClickingOn_Product4()
    {
        if (GameRules.NoDebt(10000) & GameRules.OnceTouched(GameObject.Find("Product #4")))
        {
            GameObject.Find("Money").GetComponent<Text>().text = '$' + Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimStart('$')) - 10000);
            GameObject.Find("Product #4").GetComponentInChildren<Text>().text = "Куплено";
        }
    }
}