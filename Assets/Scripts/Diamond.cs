using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private int diamond = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Diamond")
        {
            diamond++;
            Debug.Log(diamond);
            Destroy(other.gameObject);
        }
    }
}
