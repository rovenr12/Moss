using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public bool isGameOver = false;

    [SerializeField] private Score score;
    [SerializeField] private RainDropGenerator rainDropGenerator;
    [SerializeField] private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            if (score.GetScore() < 0 || timer.GetCurrentTime() <= 0)
            {
                isGameOver = true;
                rainDropGenerator.enabled = false;
                timer.enabled = false;
            }
        }
    }
}
