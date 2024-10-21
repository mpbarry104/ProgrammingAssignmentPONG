using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ballscore : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        float speed = 5.0f;
        transform.position += Vector3.left * speed * dt;
  int score1 = 0;
  int score2 = 0;

// player 1 goal
        if (transform.position.x >= 10)
        {
          score1++;
            transform. position = new Vector3(0.0f, 0.0f, 0.0f);
             Debug.Log("Player 1's score is now" + score1);
        }
              
              
              
//player 2 goal
               if (transform.position.x <= -10)
        {
            score2++;
            transform. position = new Vector3(0.0f, 0.0f, 0.0f);
             Debug.Log("Player 2's score is now" + score2);
        }



        
    }
}
