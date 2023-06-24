using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerLab1 : MonoBehaviour
{
    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }
    public GameObject one;
        public GameObject two;
    
    public void step1()
    {
        SceneManager.LoadSceneAsync("Step1",LoadSceneMode.Additive);
        one.SetActive(false);
        two.SetActive(false);
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("subject");
        }
    }
    
}
