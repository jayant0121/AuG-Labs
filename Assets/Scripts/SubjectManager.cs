using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubjectManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MenuPanel;
    public GameObject PhysicsPanel;
    public GameObject ChemistryPanel;
    public GameObject MathsPanel;
    public GameObject UnderDevelopmentPanel;
    void Start()
    {
        MenuPanel.SetActive(true);
        PhysicsPanel.SetActive(false);
        ChemistryPanel.SetActive(false);
        MathsPanel.SetActive(false);
        Screen.orientation = ScreenOrientation.Portrait;
    }
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Escape))
        {
            BackPress();
        }
    }
    public void OnPhysics()
    {
        MenuPanel.SetActive(false);
        PhysicsPanel.SetActive(true);
    }
    public void OnChmistry()
    {
        MenuPanel.SetActive(false);
        ChemistryPanel.SetActive(true);
    }public void OnMaths()
    {
        MenuPanel.SetActive(false);
        MathsPanel.SetActive(true);
    }
    public void OnLOR()
    {
        SceneManager.LoadScene("LORscene2");
    }
    public void BackPress()
    {
        UnderDevelopmentPanel.SetActive(false);
        MenuPanel.SetActive(true);
        PhysicsPanel.SetActive(false);
        ChemistryPanel.SetActive(false);
        MathsPanel.SetActive(false);
    }
    public void BRclick()
    {
        SceneManager.LoadScene("BRlab");
    }
    public void CClick()
    {
        SceneManager.LoadScene("ECS1");
    }
}
