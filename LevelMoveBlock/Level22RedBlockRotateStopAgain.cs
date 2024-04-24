using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level22RedBlockRotateStopAgain : MonoBehaviour
{
    public GameObject RedBlock;
    public float RotateSpeed;
    public float FirstZ;
    private float RotateTime = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateTime += Time.deltaTime;
        

        if (RotateTime >= 0 && RotateTime < 3)
        {
            RedBlock.transform.Rotate(0, 0, RotateSpeed * Time.deltaTime);
        }
        if (RotateTime >= 3 && RotateTime < 4)
        {
            RedBlock.transform.localRotation = Quaternion.Euler(0, 0, FirstZ);
        }
        if (RotateTime > 4)
        {
            RedBlock.transform.localRotation = Quaternion.Euler(0, 0, FirstZ);
            RotateTime = 0;
        }
    }

    private void OnEnable()
    {
        RedBlock.transform.localRotation = Quaternion.Euler(0, 0, FirstZ);
    }

    private void OnDisable()
    {
        RotateTime = 0;
    }
}
