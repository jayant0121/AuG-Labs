using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterAnim : MonoBehaviour
{
   private Animator anim;
   public GameObject g1;
   public GameObject g2;
   public GameObject g3;
   public GameObject g4;
   
   void start(){
    anim = GetComponent<Animator>();
   }
   public void AfterAnimation(){
    g1.SetActive(true);
   g2.SetActive(true);
    g3.SetActive(false);
   g4.SetActive(false);
   }
   
}

