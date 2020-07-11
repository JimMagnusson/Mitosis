using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWalk : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        HelpFunctions.MoveTheThing(rb, RandomVector2D(-1f, 1f), 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector2 RandomVector2D(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(min, max);
        return new Vector2(x, y);
    }
}
