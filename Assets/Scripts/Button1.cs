using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    public CarMovement2 movement;
    public void startCar()
    {
        movement.enabled = true;
    }
}
