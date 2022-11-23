using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class ChestScript : Interactive
{
    public Animator animator;
    private void Awake()
    {
        GetComponent<Animator>().Play("Idle");
    }
    public override void OnInteraction()
    {
        //If I want to do the base OnInteraction anyway first
        //
        //Activate Chest & Key
        GetComponent<Animator>().SetTrigger("ChestOpen");

    }
}