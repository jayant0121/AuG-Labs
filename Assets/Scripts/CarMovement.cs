using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CarMovement : MonoBehaviour
{
    public Text v1f;
    public GameObject Start1;
    public GameObject next;
    public static float v2;
    public static float m1;
    public static float m2;
    public static float v1;
    public static bool crash;
    public Rigidbody car;
    void Awake(){
    crash = false;
    }
    void Start()
    {
        v1f.text = "v1 of mass 1: " + v1.ToString();
    }
   
    
    void FixedUpdate()
    {
        Vector3 pos = new Vector3(transform.position.x + v1*0.0001f,transform.position.y,transform.position.z);
        transform.position = pos;
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag  == "Car2")
        {
            if(crash)
            {
                v1=0;
            }
            else
            v1 = ((m1-m2)*v1 + (2*m2*v2))/(m1+m2);
            SceneManager_Final.v1fi = v1;
            v1f.text = "Vmass1: " + v1.ToString("0.00");
        }
        if(other.collider.tag == "Roadblock")
        {
            v1=0;
            crash = true;
            CarMovement2.crash = true;
            v1f.text = "Vmass1: " + v1.ToString("0.00");
           next.SetActive(true);
                Start1.SetActive(false);
            
        }
    }
}
