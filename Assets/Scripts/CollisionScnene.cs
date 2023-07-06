using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScnene : MonoBehaviour
{
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("subject");
        }
    }
    public void ChangeValues()
    {
        SceneManager.LoadScene("ECS1");

    }
    public void ChangeSceneFinal()
    {
        SceneManager.LoadSceneAsync("Final_results");
    }
}
