using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private int timeLimit = 90;

    [SerializeField] private int currentTime = 0;

    private bool startTimer = true;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = timeLimit;
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(1);
        currentTime--;
        startTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0 && startTimer)
        {
            StartCoroutine("timer");
            startTimer = false;
        }
    }

    public int GetCurrentTime()
    {
        return currentTime;
    }
}
