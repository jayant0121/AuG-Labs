using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleEffect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particles;
    void start(){
        particles.SetActive(false);
    }
    public void particlestart()
    {
        particles.SetActive(true);
    }
}
