using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score = 0;

    public void AddScore()
    {
        score += 1;
        GetComponent<Text>().text = score.ToString();
    }
}
