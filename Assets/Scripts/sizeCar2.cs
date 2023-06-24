using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeCar2 : MonoBehaviour
{
    public void Awake(){
        int m2 = (int)Menu.m2/100 + 1;
        float size = transform.localScale.x + m2*0.001f;
        transform.localScale = new Vector3(size,size,size);
        transform.position = new Vector3(transform.position.x,transform.position.y + m2*0.001f,transform.position.z);
    }
}

