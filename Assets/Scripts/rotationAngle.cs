using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Drawing;
public class rotationAngle : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider abc;
    public float angle=0;
 
   // Update is called once per frame
    void Update()
    {
        float angleU = abc.value;
        transform.eulerAngles = new Vector3(0,angleU,0);
    }
    
}
