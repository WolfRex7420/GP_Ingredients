using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoor : Interactive
{
    //Basic behaviour for Interactive objects is to trigger an animation
    //virtual makes the function changeable in children classes
    public override void OnInteraction()
    {
        if (requiredItems)
        {
            GetComponent<Animator>().SetTrigger("SecondDoorOpen");
        }
        GetComponent<Animator>().SetTrigger("Failed");
    }
}