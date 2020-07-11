using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        MoveTheThing(rb, Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void MoveTheThing(Rigidbody2D rb, float X, float Y) {
        Vector2 dir = new Vector2(X,Y); 
        dir.Normalize();
        rb.velocity = dir * speed;
    }
}
