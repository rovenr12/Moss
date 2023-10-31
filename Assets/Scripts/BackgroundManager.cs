using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private Score score;
    [SerializeField] private Sprite[] backgrounds;
    [SerializeField] private int threshold = 10;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        score = GetComponent<Score>();
        spriteRenderer.sprite = backgrounds[0];
    }

    // Update is called once per frame
    void Update()
    {
        int level = score.GetScore() / threshold;
        if (level > backgrounds.Length)
        {
            spriteRenderer.sprite = backgrounds[^1];
        }
        else
        {
            spriteRenderer.sprite = backgrounds[level];
        }
    }
}
