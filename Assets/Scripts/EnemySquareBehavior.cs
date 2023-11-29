using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySquareBehavior : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private SpriteRenderer mainSprite;
    [SerializeField] private float speed;
    [SerializeField] private float durationBeforeSwitching;

    private float timeInCurrentDirection = 0f;
    private int direction = 0;

    void Start()
    {
    }

    void FixedUpdate()
     {
         Move(Time.fixedDeltaTime);
     }

    public void Move(float dt)
    {
         timeInCurrentDirection = timeInCurrentDirection + dt;
         if (direction == 0)
         {
             rb2D.MovePosition(rb2D.position + dt * speed * Vector2.left);
             mainSprite.flipX = false;
         }
         else if (direction == 2)
         {
             rb2D.MovePosition(rb2D.position + dt * speed * Vector2.right);
             mainSprite.flipX = true;
         }

         else if (direction == 1)
        {
            rb2D.MovePosition(rb2D.position + dt * speed * Vector2.up);
        }

        else if (direction == 3)
        {
            rb2D.MovePosition(rb2D.position + dt * speed * Vector2.down);
        }

        if (timeInCurrentDirection > durationBeforeSwitching)
        {
            direction++;
            if (direction == 4)
            {
                direction = 0;
            }
            timeInCurrentDirection = 0f;
        }
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

}
