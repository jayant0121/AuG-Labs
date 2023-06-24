using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubjectManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Menu;
    public GameObject Physics;
    public GameObject Chemistry;
    public GameObject Maths;
    void Start()
    {
        Menu.SetActive(true);
        Physics.SetActive(false);
        Chemistry.SetActive(false);
        Maths.SetActive(false);
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
        Menu.SetActive(false);
        Physics.SetActive(true);
    }
    public void OnChmistry()
    {
        Menu.SetActive(false);
        Chemistry.SetActive(true);
    }public void OnMaths()
    {
        Menu.SetActive(false);
        Maths.SetActive(true);
    }
    public void OnLOR()
    {
        SceneManager.LoadScene("LORscene1");
    }
    public void BackPress()
    {
        Menu.SetActive(true);
        Physics.SetActive(false);
        Chemistry.SetActive(false);
        Maths.SetActive(false);
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
