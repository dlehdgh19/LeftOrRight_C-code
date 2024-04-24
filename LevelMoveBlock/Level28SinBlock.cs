using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level28SinBlock : MonoBehaviour
{
    private float SinTime = 0;
    public float Speed;
    private float sinfloat = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SinTime += 90 * Speed * Time.deltaTime;
        sinfloat = SinTime * Mathf.Deg2Rad;
        this.transform.localScale = new Vector3(11 * Mathf.Sin(sinfloat), 1, 1);
    }

    private void OnEnable()
    {
        SinTime = 0;
        this.transform.localScale = new Vector3(0, 1, 1);
    }

    private void OnDisable()
    {
        SinTime = 0;
        this.transform.localScale = new Vector3(0, 1, 1);
    }
}
