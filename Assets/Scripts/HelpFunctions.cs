using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class HelpFunctions
{
    public static void MoveTheThing(Rigidbody2D rb, float X, float Y, float speed) {
        Vector2 dir = new Vector2(X,Y);
        dir.Normalize();
        rb.velocity = dir * speed;
    }
    public static void MoveTheThing(Rigidbody2D rb, Vector2 direction, float speed)
    {
        Vector2 dir = direction;
        dir.Normalize();
        rb.velocity = dir * speed;
    }
}
