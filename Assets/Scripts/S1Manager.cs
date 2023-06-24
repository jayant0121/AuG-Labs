using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S1Manager : MonoBehaviour
{
    
    public GameObject one;
        public GameObject two;
        
        public GameObject three;
    public void step2()
    {
        SceneManager.LoadScene("Step2",LoadSceneMode.Additive);
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
        
    }
    
}
