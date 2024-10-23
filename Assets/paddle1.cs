using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle1 : MonoBehaviour
{
    public GameObject ball;
    public GameObject lpaddle;
    public GameObject rpaddle;

    new BoxCollider2D collider;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
         collider = GetComponent<BoxCollider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // x & y are the centre of our rectangle (game object)
        float bx = ball.transform.position.x;
        float by = ball.transform.position.y;
        float bhw = collider.size.x * ball.transform.localScale.x * 0.5f;
        float bhh = collider.size.y * ball.transform.localScale.y * 0.5f;

        // Use min & max values to do your point-rectangle test against the mouse!
        float bxMin = bx - bhw;
        float bxMax = bx + bhw;
        float byMin = by - bhh;
        float byMax = by + bhh;

           // x & y are the centre of our rectangle (game object)
        float lx = lpaddle.transform.position.x;
        float ly = lpaddle.transform.position.y;
        float lhw = collider.size.x * lpaddle.transform.localScale.x * 0.5f;
        float lhh = collider.size.y * lpaddle.transform.localScale.y * 0.5f;

        // Use min & max values to do your point-rectangle test against the mouse!
        float lxMin = lx - lhw;
        float lxMax = lx + lhw;
        float lyMin = ly - lhh;
        float lyMax = ly + lhh;

         Debug.DrawLine(new Vector3(lxMin, lyMin), new Vector3(lxMin, lyMax), Color.red);
        Debug.DrawLine(new Vector3(lxMax, lyMin), new Vector3(lxMax, lyMax), Color.yellow);
        Debug.DrawLine(new Vector3(lxMin, lyMin), new Vector3(lxMax, lyMin), Color.blue);
        Debug.DrawLine(new Vector3(lxMin, lyMax), new Vector3(lxMax, lyMax), Color.green);

             // x & y are the centre of our rectangle (game object)
        float rx = rpaddle.transform.position.x;
        float ry = rpaddle.transform.position.y;
        float rhw = collider.size.x * rpaddle.transform.localScale.x * 0.5f;
        float rhh = collider.size.y * rpaddle.transform.localScale.y * 0.5f;

        // Use min & max values to do your point-rectangle test against the mouse!
        float rxMin = rx - rhw;
        float rxMax = rx + rhw;
        float ryMin = ry - rhh;
        float ryMax = ry + rhh;
if (bxMin < lxMin)
        {
            Debug.Log("hit left paddle right side");
        }
        else if (bxMax > lxMax)
        {
            sr.color = Color.red;
        }
       else if (byMin < lyMin)
        {
            Debug.Log("hit left paddle bottom");
        }
        else if (byMax > lyMax)
        {
            Debug.Log("Hit LPaddle top");
        }
        else if (bxMin < rxMax)
        {
            Debug.Log("Hit right paddle Left");
        }

        else if (bxMax > rxMax)
        {
            sr.color = Color.red;
        }
        else if (byMin < ryMin)
        {
            Debug.Log("Hit Bottom of Rpaddle");
        }
        else if (byMin < ryMin)
        {
            Debug.Log("Hit Bottom RPaddle");
        }
        else if (byMax > ryMax)
        {
            Debug.Log("Hit top of rpaddle");
        }


    }
}
