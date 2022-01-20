using UnityEngine;

public class MainPartSwitcher : MonoBehaviour
{
    public GameObject HostelPanel;
    public GameObject UniversityPanel;
    public GameObject CareerPanel;
    public GameObject ShopPanel;

    public void OpenUniversityPanel()
    {
        HostelPanel.gameObject.SetActive(false);
        UniversityPanel.gameObject.SetActive(true);
        ShopPanel.gameObject.SetActive(false);
        CareerPanel.gameObject.SetActive(false);
    }
    public void OpenCareerPanel()
    {
        HostelPanel.gameObject.SetActive(false);
        UniversityPanel.gameObject.SetActive(false);
        ShopPanel.gameObject.SetActive(false);
        CareerPanel.gameObject.SetActive(true);
    }
    public void OpenShopPanel()
    {
        HostelPanel.gameObject.SetActive(false);
        UniversityPanel.gameObject.SetActive(false);
        ShopPanel.gameObject.SetActive(true);
        CareerPanel.gameObject.SetActive(false);
    }
    public void OpenHostelPanel()
    {
        HostelPanel.gameObject.SetActive(true);
        UniversityPanel.gameObject.SetActive(false);
        ShopPanel.gameObject.SetActive(false);
        CareerPanel.gameObject.SetActive(false);
    }
}