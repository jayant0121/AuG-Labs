using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public static Menu instance;
    public  TMP_InputField V1;
    public TMP_InputField V2;
    public TMP_InputField M1;
    public TMP_InputField M2;
    public TMP_Text warning;
    public GameObject errorPanel;
    public GameObject MenuPanel;
    
    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Subject");
        }
    }
    public static float v1,v2,m1,m2;
    private void Awake(){
        instance=this;
        DontDestroyOnLoad(this.gameObject);
    }
    public float correctValueM(float mass){
        if(mass>=200 && mass<=1000)
        {
            return mass;
        }
        else
        {
            warning.text = "Please enter values of mass and velocity in the given range";
            return -1;
        }
    }
    public float correctValueV(float velocity){
        
        if(Mathf.Abs(velocity)>=5 && Mathf.Abs(velocity)<=40)
        {  
            return velocity;
        }
        else
        {
             warning.text = "Please enter values of mass and velocity in the given range";
             return -1;
        }
    }
    
    public void passValues()
    {
        v1 = float.Parse(V1.text);
        v1 = correctValueV(v1);        
        v2 = float.Parse(V2.text);
        v2= correctValueV(v2);
        m1 = float.Parse(M1.text);
        m1=correctValueM(m1);
        m2 = float.Parse(M2.text);
        m2=correctValueM(m2);
        CarMovement.v1 = v1;
        CarMovement.v2 = v2;
        CarMovement.m2 = m2;
        CarMovement.m1 = m1;
        CarMovement2.v1 = v1;
        CarMovement2.v2 = v2;
        CarMovement2.m2 = m2;
        CarMovement2.m1 = m1;
        SceneManager_Final.m1 = m1;
        SceneManager_Final.m2 = m2;
        SceneManager_Final.v1 = v1;
        SceneManager_Final.v1 = v2;
        if((v1==-1 || v2==-1 || m1==-1 || m2==-1))
        {
            errorPanel.SetActive(true);
            MenuPanel.GetComponent<Image>().color = new Color32(255,255,255,127);
        }
        else{
            
        SceneManager.LoadScene("Collision");
        }
    }
    public void BackToMenu()
    {
        errorPanel.SetActive(false);
        MenuPanel.GetComponent<Image>().color = new Color32(255,255,255,255);
    }
    
}
