using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class rotationAngleforOutgoing : MonoBehaviour
{
    // Start is called before the first frame update
     // Start is called before the first frame update
    public Slider abc;
    public float angle=0;
 
   // Update is called once per frame
    void Update()
    {
        float angleU = abc.value;
        transform.eulerAngles = new Vector3(0,-1*angleU,0);
    }
}
