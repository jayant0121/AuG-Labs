using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownRingAppear : MonoBehaviour
{
  public GameObject brownring;
  public GameObject CanvasText;
  public GameObject keep45;
  public GameObject startbutton;
  public GameObject FinishButton;
  public void afteranim()
  {
    
    keep45.SetActive(false);
    CanvasText.SetActive(true);
    startbutton.SetActive(false);
  }
  public void BrownRingAp()
  {
    brownring.SetActive(true);
    FinishButton.SetActive(true);
  }

}
