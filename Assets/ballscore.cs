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
        transform.position += Vector3.left * speed * dt;
        double a = 0;

        if (transform.position.x >= 10)
        {

            transform. position = new Vector3(0.0f, 0.0f, 0.0f);
            double aa = a++;
            double aaa = ++a;
             Debug.Log("Player 1's score is now" + aaa);
        }
               if (transform.position.x <= -10)
        {

            transform. position = new Vector3(0.0f, 0.0f, 0.0f);
            double aa = a++;
            double aaa = ++a;
             Debug.Log("Player 2's score is now" + aaa);
        }



        
    }
}
