using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDropGenerator : MonoBehaviour
{
    [SerializeField] private int minX;
    [SerializeField] private int maxX;
    [SerializeField] private int yPosition;
    [SerializeField] private Score score;
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private int generateFrequency;
    [SerializeField] private GameLogic gameLogic;

    private bool startTimer = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    IEnumerator timer()
    {
        int xPosition = Random.Range(minX, maxX);
        int prefabNumber = Random.Range(0, prefabs.Length);
        GameObject newDrop = Instantiate(prefabs[prefabNumber], new Vector3(xPosition, yPosition), Quaternion.identity);
        RainDrop rainDrop = newDrop.GetComponent<RainDrop>();
        rainDrop.SetScore(score);
        rainDrop.SetGameLogic(gameLogic);
        
        yield return new WaitForSeconds(generateFrequency);
        startTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            StartCoroutine("timer");
            startTimer = false;
        }
    }
}
