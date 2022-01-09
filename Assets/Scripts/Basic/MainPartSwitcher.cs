using UnityEngine;

public class MainPartSwitcher : MonoBehaviour
{
    public GameObject HostelPanel;
    public GameObject UniversityPanel;
    public GameObject CareerPanel;
    public void OpenUniversityPanel()
    {
        HostelPanel.gameObject.SetActive(false);
        UniversityPanel.gameObject.SetActive(true);
        CareerPanel.gameObject.SetActive(false);
    }
    public void OpenCareerPanel()
    {
        HostelPanel.gameObject.SetActive(false);
        UniversityPanel.gameObject.SetActive(false);
        CareerPanel.gameObject.SetActive(true);
    }
    public void OpenHostelPanel()
    {
        HostelPanel.gameObject.SetActive(true);
        UniversityPanel.gameObject.SetActive(false);
        CareerPanel.gameObject.SetActive(false);
    }
}