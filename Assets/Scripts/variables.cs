using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class variables : MonoBehaviour
{
    public TMP_InputField M1;
    public TMP_InputField M2;
    public TMP_InputField V1;
    public TMP_InputField V2;
public static int m1,m2,v1,v2;
void Start(){
    m1 = int.Parse(M1.text);
    m2 = int.Parse(M2.text);
    v1 = int.Parse(V1.text);
    v2 = int.Parse(V2.text);
}
}
