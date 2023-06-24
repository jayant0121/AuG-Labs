using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }
   public void PlayGame ()
    {
        SceneManager.LoadScene("LORscene2");
    }
    public void GoBack ()
    {
        SceneManager.LoadScene("subject");
    }
}
