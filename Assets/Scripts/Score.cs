using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int point = 0;
    public void AddScore(int score)
    {
        point += score;
    }

    public int GetScore()
    {
        return point;
    }
}
