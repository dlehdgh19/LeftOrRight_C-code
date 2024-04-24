using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level26LookZero : MonoBehaviour
{
    
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Look = transform.InverseTransformPoint(Ball.transform.position);
        float Angle = Mathf.Atan2(Look.y, Look.x) * Mathf.Rad2Deg + 90;
        transform.Rotate(0, 0, Angle);
        

    }
}
