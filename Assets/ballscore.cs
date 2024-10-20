using System.Collections;
using System.Collections.Generic;
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
        transform.position += Vector3.right * speed * dt;
        int score = 0;
        int P1Score = ++score;

        if (transform.position.x >= 10)
        {

            transform. position = new Vector3(0.0f, 0.0f, 0.0f);
            P1Score = P1Score + score++;
            Debug.Log("currently player 1's score is " + P1Score);
        }


        
    }
}
