using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Failed : MonoBehaviour
{
    public InteractionType interactionType = InteractionType.OpenDoor;

    public bool onlyOnce = false;

    [Header("Condition")]
    public KeyItemData requiredItem;

    public bool waitForObject;

    //Basic behaviour for Interactive objects is to trigger an animation
    //virtual makes the function changeable in children classes
    public virtual void OnInteraction()
    {
        GetComponent<Animator>().SetTrigger("Failed");
    }


}
