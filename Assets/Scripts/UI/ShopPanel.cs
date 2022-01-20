using System;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanel : MonoBehaviour
{
    public string Product1Name;
    public int Product1Cost;

    public string Product2Name;
    public int Product2Cost;

    public string Product3Name;
    public int Product3Cost;

    public string Product4Name;
    public int Product4Cost;

    void Awake()
    {
        GameObject.Find("Product #1").GetComponentInChildren<Text>().text = GameObject.Find("Shop Panel").GetComponent<ShopPanel>().Product1Name + "  " +
            Convert.ToString(GameObject.Find("Shop Panel").GetComponent<ShopPanel>().Product1Cost) + "₽";
        GameObject.Find("Product #2").GetComponentInChildren<Text>().text = GameObject.Find("Shop Panel").GetComponent<ShopPanel>().Product2Name + "  " +
            Convert.ToString(GameObject.Find("Shop Panel").GetComponent<ShopPanel>().Product2Cost) + "₽";
        GameObject.Find("Product #3").GetComponentInChildren<Text>().text = GameObject.Find("Shop Panel").GetComponent<ShopPanel>().Product3Name + "  " +
            Convert.ToString(GameObject.Find("Shop Panel").GetComponent<ShopPanel>().Product3Cost) + "₽";
        GameObject.Find("Product #4").GetComponentInChildren<Text>().text = GameObject.Find("Shop Panel").GetComponent<ShopPanel>().Product4Name + "  " +
            Convert.ToString(GameObject.Find("Shop Panel").GetComponent<ShopPanel>().Product4Cost) + "₽";
    }
    public void ClickingOn_Product1()
    {
        if (GameRules.NoDebt(Product1Cost) & GameRules.OnceTouched(GameObject.Find("Product #1")))
        {
            GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽')) - Product1Cost) + "₽";
            GameObject.Find("Product #1").GetComponentInChildren<Text>().text = "Куплено";
        }
    }
    public void ClickingOn_Product2()
    {
        if (GameRules.NoDebt(Product2Cost) & GameRules.OnceTouched(GameObject.Find("Product #2")))
        {
            GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽')) - Product2Cost) + "₽";
            GameObject.Find("Product #2").GetComponentInChildren<Text>().text = "Куплено";
        }
    }
    public void ClickingOn_Product3()
    {
        if (GameRules.NoDebt(Product3Cost) & GameRules.OnceTouched(GameObject.Find("Product #3")))
        {
            GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽')) - Product3Cost) + "₽";
            GameObject.Find("Product #3").GetComponentInChildren<Text>().text = "Куплено";
        }
    }
    public void ClickingOn_Product4()
    {
        if (GameRules.NoDebt(Product4Cost) & GameRules.OnceTouched(GameObject.Find("Product #4")))
        {
            GameObject.Find("Money").GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(GameObject.Find("Money").GetComponent<Text>().text.TrimEnd('₽')) - Product4Cost) + "₽";
            GameObject.Find("Product #4").GetComponentInChildren<Text>().text = "Куплено";
        }
    }
}