using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size_Car1 : MonoBehaviour
{
    public void Awake(){
        int m1 = (int)Menu.m1/100;
        float size = transform.localScale.x + m1*0.001f;
        transform.localScale = new Vector3(size,size,size);
        transform.position = new Vector3(transform.position.x,transform.position.y + m1*0.001f,transform.position.z);
    }
}

