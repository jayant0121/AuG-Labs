using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CarMovement2 : MonoBehaviour
{
    public GameObject next;
    
    public GameObject Start1;
    public static float v2;
    public static  float v1;
    public static float m1;
    public static float m2;
    public static bool crash;
    public Rigidbody car;
    public Text v2f;
    void Awake(){
    crash = false;
    }
    void Start()
    {
        v2f.text = "Vf of mass 2: " + v2.ToString();
    }
    void FixedUpdate()
    {
        Vector3 pos = new Vector3(transform.position.x + v2*0.0001f,transform.position.y,transform.position.z);
        transform.position = pos;
    }
     void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag  == "Car1")
        {
            if(crash)
            {
                v2=0;
            }
            else
            v2 = (float)((m2-m1)*v2 + (2*v1*m1))/(m1+m2);
            SceneManager_Final.v2fi = v2;
            
            v2f.text = "Vmass2: " + v2.ToString("0.00");
        }
        if(other.collider.tag == "Roadblock")
        {
            v2=0;
            crash = true;
            CarMovement.crash = true;
            v2f.text = "Vmass2: " + v2.ToString("0.00");
                next.SetActive(true);
                Start1.SetActive(false);
        }
    }
}
