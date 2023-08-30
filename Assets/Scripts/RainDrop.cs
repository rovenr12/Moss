using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrop : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private Score score;
    [SerializeField] private GameLogic gameLogic;
    [SerializeField] int point = 10;
    [SerializeField] private int failPoint = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetScore(Score score)
    {
        this.score = score;
    }

    public void SetGameLogic(GameLogic gameLogic)
    {
        this.gameLogic = gameLogic;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameLogic.isGameOver)
        {
            return;
        }
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            score.AddScore(point);
        }
        else
        {
            score.AddScore(failPoint);
        }
        Destroy(gameObject);
    }
    
}
