using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JailDoor : Interactive
{
    //Basic behaviour for Interactive objects is to trigger an animation
    //virtual makes the function changeable in children classes
    public override void OnInteraction()
    {
        if (requiredItem)
        {
            GetComponent<Animator>().SetTrigger("JailDoorOpen");
        }
        GetComponent<Animator>().SetTrigger("Failed");
    }
}