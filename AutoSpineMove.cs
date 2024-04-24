using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpineMove : MonoBehaviour
{
    private float MovingTime = 0;
    public float MovingFloat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovingTime += Time.deltaTime;
        if(MovingTime > 0 && MovingTime < 1f)
        {
            gameObject.GetComponent<PolygonCollider2D>().enabled = true;
            transform.Translate(new Vector3(0, MovingFloat, 0) * Time.deltaTime);
        }
        if(MovingTime > 3 && MovingTime < 4f)
        {
            transform.Translate(new Vector3(0, -MovingFloat, 0) * Time.deltaTime);
        }
        if (MovingTime > 4 && MovingTime < 6f)
        {
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        }
        if (MovingTime > 6)
        {
            MovingTime = 0;
        }

    }
}
