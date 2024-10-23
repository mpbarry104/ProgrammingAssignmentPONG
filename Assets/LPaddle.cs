using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPaddle: MonoBehaviour
{
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
        float lx = transform.position.x;
        float ly = transform.position.y;
        float lhw = collider.size.x * transform.localScale.x * 0.5f;
        float lhh = collider.size.y * transform.localScale.y * 0.5f;

        // Use min & max values to do your point-rectangle test against the mouse!
        float lxMin = lx - lhw;
        float lxMax = lx + lhw;
        float lyMin = ly - lhh;
        float lyMax = ly + lhh;

         Debug.DrawLine(new Vector3(lxMin, lyMin), new Vector3(lxMin, lyMax), Color.red);
        Debug.DrawLine(new Vector3(lxMax, lyMin), new Vector3(lxMax, lyMax), Color.yellow);
        Debug.DrawLine(new Vector3(lxMin, lyMin), new Vector3(lxMax, lyMin), Color.blue);
        Debug.DrawLine(new Vector3(lxMin, lyMax), new Vector3(lxMax, lyMax), Color.green);

    }
}
