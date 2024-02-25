using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class VagrancyModeStrategy : IModeStrategy
{
    public int randomDirection;
    private float speed;
    private Rigidbody2D rigidBody;
    Vector2 direction = Vector2.zero;
    public VagrancyModeStrategy(int rd, Rigidbody2D rb, float sp)
    {
        randomDirection = rd;
        speed = sp;
        rigidBody = rb;
    }
    public void PerformMode()
    {
        if (randomDirection == 0)
        {
            direction = Vector2.up;
        }
        else if (randomDirection == 1)
        {
            direction = Vector2.down;
        }
        else if (randomDirection == 2)
        {
            direction = Vector2.right;
        }
        else if (randomDirection == 3)
        {
            direction = Vector2.left;
        }

        rigidBody.velocity = direction * speed;
    }
}
