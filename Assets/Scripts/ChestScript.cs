
using UnityEngine;

public class ChestScript : Interactive
{
    public Animator animator;
    public GameObject SilverKey;

    public override void OnInteraction()
    {
        //If I want to do the base OnInteraction anyway first
        //
        //Activate Chest & Key
        GetComponent<Animator>().Play("Open Chest Lid");
        SilverKey.SetActive(true);
    }
}