using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class LMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }
          if (transform.position.y > 3.61f)
        {
            direction.y = -direction.y;
        }
        else if (transform.position.y < -3.61f)
        {
            direction.y = -direction.y;
        }
  
  float dt = Time.deltaTime;
        float speed = 4.0f;
        Vector3 change = direction * speed * dt;
        transform.position = transform.position + change;
    }
}