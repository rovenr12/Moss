using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    [SerializeField] private GameLogic gameLogic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameLogic.isGameOver)
        {
            return;
        }
        if (Input.GetButton("Horizontal"))
        {
            float x = Input.GetAxis("Horizontal");
            transform.Translate(x * speed * Time.deltaTime, 0, 0);
        }
    }
}
