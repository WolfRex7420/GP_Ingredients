using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    public GameObject Chest;

    private void Start()
    {
        Chest = GetComponent<GameObject>();
    }

    void FixedUpdate()
    {
        if (WallTorch.litTorchesCount == 3)
        {
            //spawn chest
            Chest.SetActive(true);
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
