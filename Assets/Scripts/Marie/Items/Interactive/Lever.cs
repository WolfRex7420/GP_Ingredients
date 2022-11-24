using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactive
{
    public GameObject Key_Golden;
    //Basic behaviour for Interactive objects is to trigger an animation
    //virtual makes the function changeable in children classes
    public override void OnInteraction()
    {
        GetComponent<Animator>().SetTrigger("Switch");
        Key_Golden.SetActive(true);
    }
}
