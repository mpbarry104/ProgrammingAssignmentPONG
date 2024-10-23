using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ballscore : MonoBehaviour
{
  private int score1 = 0;
  private int score2 = 0;
  //saving ball score
   Vector2 direction = Vector2.up;


    // Start is called before the first frame update
    void Start()
    {
        //made the ball bounce
       float angle = 65.0f * Mathf.Deg2Rad;
        direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        float speed = 5.0f;
        Vector3 change = direction * speed * dt;
        transform.position += change;
      //bounces off ceiling (y)
         if (transform.position.y < 4.75f)
        {
            direction.y = -direction.y;
        }
if (transform.position.y > -4.75f)
        {
            direction.y = -direction.y;
        }
//randomizer for direction
 static int number(int min, int max)
        {
            System.Random random = new System.Random();
            return random.Next(1, 3);
        }
   


// player 1 goal
        if (transform.position.x >= 10)
        {
          score1++;
            transform. position = new Vector3(0.0f, 0.0f, 0.0f);
             Debug.Log("Player 1's score is now" + score1);

             //tried randomizing direction here not sure why it didnt work
                     if (number(1, 3) == 1)
        {
            transform.position += Vector3.left * speed * dt;
        }

         if (number(1, 3) == 2)
        {
          transform.position += Vector3.right * speed *dt;
        }
        }
              
              
              
//player 2 goal
               if (transform.position.x <= -10)
        {
            score2++;
            transform. position = new Vector3(0.0f, 0.0f, 0.0f);
             Debug.Log("Player 2's score is now" + score2);

             //tried randomizing direction here not sure why it didnt work
                     if (number(1, 3) == 1)
        {
            transform.position += Vector3.left * speed * dt;
        }

        if (number(1, 3) == 2)
        {
          transform.position += Vector3.right * speed *dt;
        }
        }
    }
}
