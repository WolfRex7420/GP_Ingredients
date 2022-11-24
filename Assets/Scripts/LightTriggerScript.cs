using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTriggerScript : MonoBehaviour
{
    public BoxCollider Collider;
    private void OnTriggerEnter (Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
