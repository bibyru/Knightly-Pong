using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Castle : MonoBehaviour
{
    [SerializeField] AudioSource RobloxOof;

    int breaknum = 0;

    public void Break()
    {
        if (breaknum + 1 > 2)
        {
            breaknum = -1;

            if (gameObject.name == "1_Castle")
            {
                GameObject.Find("P2Score").GetComponent<Score>().AddScore();
            }
            else
            {
                GameObject.Find("P1Score").GetComponent<Score>().AddScore();
            }

            RobloxOof.Play();
        }

        breaknum += 1;

        GetComponent<Animator>().SetInteger("breaknum", breaknum);
    }
}
