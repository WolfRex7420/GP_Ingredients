using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class LightKeyGold : Interactive
{
    public GameObject Key_Golden;
    public override void OnInteraction()
    {
        Key_Golden.SetActive(true);
        //If I want to do the base OnInteraction anyway first
        //
        //Activate light and fire
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
    }
}
