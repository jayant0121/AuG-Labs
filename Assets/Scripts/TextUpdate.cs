using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdate : MonoBehaviour
{
    public TMP_Text hello;
    public static string sid;
    void Start()
    {
        string hello1 = "Welcome : " + sid;
        hello.text = hello1;
    }

}
