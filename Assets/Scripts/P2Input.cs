using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Input : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            gameObject.GetComponent<KnightMovement>().Move(1);
        }

        else if (Input.GetKey(KeyCode.L))
        {
            gameObject.GetComponent<KnightMovement>().Move(-1);
        }

        else
        {
            gameObject.GetComponent<KnightMovement>().Move(0);
        }
    }
}
