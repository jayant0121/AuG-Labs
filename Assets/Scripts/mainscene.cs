using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainscene : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadSceneAsync("Authentication");
    }
}
