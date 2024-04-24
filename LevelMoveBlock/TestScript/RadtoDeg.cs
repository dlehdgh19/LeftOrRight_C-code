using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadtoDeg : MonoBehaviour
{
    private float degree;
    private float rad;
    private float time = 0;
    private float A;
    // Start is called before the first frame
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time >= 0 && time < 1)
        {
            time += Time.deltaTime;
            degree = time * Mathf.Deg2Rad;
            A = Mathf.Sin(degree);
            Debug.Log(A);
        }
        if(time >= 1)
        {
            time = 1;
            A = Mathf.Sin(degree);
            Debug.Log(A);
            // A = sin(pi/2)
        }
    }
}
