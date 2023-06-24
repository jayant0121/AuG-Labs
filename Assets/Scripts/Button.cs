using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public CarMovement movement;
    public void startCar()
    {
        movement.enabled = true;
    }
}
