using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{
    float shaketime = 0.2f;
    float timer = 0;

    public void Shake()
    {
        GetComponent<Animator>().SetBool("Shake", true);
        timer = shaketime;
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 0;
            GetComponent<Animator>().SetBool("Shake", false);
        }
    }
}
