using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public GameObject ball;
    public GameObject LPaddle;
    public GameObject RPaddle;
    private int minY;
    private int maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          float dt = Time.deltaTime;
     if (Input.GetKey(KeyCode.W))
     {
        LPaddle.transform.position = new Vector3(LPaddle.transform.position.x, Mathf.Clamp(LPaddle.transform.position.y + 0.01f, -3.5f, 3.5f));
     }
     if (Input.GetKey(KeyCode.S))
     {
        LPaddle.transform.position = new Vector3(LPaddle.transform.position.x, Mathf.Clamp(LPaddle.transform.position.y - 0.01f, -3.5f, 3.5f));
     }
      if (Input.GetKey(KeyCode.UpArrow))
     {
        RPaddle.transform.position = new Vector3(RPaddle.transform.position.x, Mathf.Clamp(RPaddle.transform.position.y + 0.01f, -3.5f, 3.5f));
     }
     if (Input.GetKey(KeyCode.DownArrow))
     {
        RPaddle.transform.position = new Vector3(RPaddle.transform.position.x, Mathf.Clamp(RPaddle.transform.position.y - 0.01f, -3.5f, 3.5f));
     }

  ball.transform.position += Vector3.right * 5.0f * dt;
  

     
    }
}
