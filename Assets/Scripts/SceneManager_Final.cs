using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneManager_Final : MonoBehaviour
{
    public TMP_Text v1i;
    public TMP_Text v2i;
    
    public TMP_Text v1f;
    public TMP_Text v2f;
    public TMP_Text KEim1;
    public TMP_Text KEim2;
    public TMP_Text KEfm1;
    public TMP_Text KEfm2;
    public TMP_Text Mim1;
    public TMP_Text Mim2;
    public TMP_Text Mfm1;
    public TMP_Text Mfm2;
    public TMP_Text M1;
    public TMP_Text M2;
    
    public TMP_Text M1f;
    public TMP_Text M2f;
    public static float m1,m2,v1,v2;
    public static float v1fi,v2fi;
    void Start()
    {
        m1 = Menu.m1;
    }
    public void QuitApp()
    {
        Application.Quit();
    }
    public float KE(float mass,float velocity)
    {
        return (float)0.5*mass*velocity*velocity;
    }
    public void Awake()
    {
        v2 = Menu.v2;
        v1 = Menu.v1;
        M1.text = m1.ToString("0" + " Kg");
        M2.text = m2.ToString("0" + " Kg");
        M1f.text = m1.ToString("0" + " Kg");
        M2f.text = m2.ToString("0" + " Kg");
        v1i.text = v1.ToString("0.00" + " m/s");
        v2i.text = v2.ToString("0.00"+" m/s");
        v1f.text = v1fi.ToString("0.00"+" m/s");
        v2f.text = v2fi.ToString("0.00"+" m/s");
        Mim1.text = (m1*v1).ToString("0.00" + " N.s");
        Mim2.text = (m2*v2).ToString("0.00"+ " N.s");
        Mfm1.text = (m1*v1fi).ToString("0.00"+ " N.s");
        Mfm2.text = (m2*v2fi).ToString("0.00"+ " N.s");
        KEim1.text = KE(m1,v1).ToString("0.00" + " J");
        KEim2.text = KE(m2,v2).ToString("0.00"+ " J");
        KEfm1.text = KE(m1,v1fi).ToString("0.00"+ " J");
        KEfm2.text = KE(m2,v2fi).ToString("0.00"+ " J");
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("subject");
        }
    }
}
