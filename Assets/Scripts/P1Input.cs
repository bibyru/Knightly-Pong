using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Input : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.GetComponent<KnightMovement>().Move(1);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            gameObject.GetComponent<KnightMovement>().Move(-1);
        }

        else
        {
            gameObject.GetComponent<KnightMovement>().Move(0);
        }
    }
}
