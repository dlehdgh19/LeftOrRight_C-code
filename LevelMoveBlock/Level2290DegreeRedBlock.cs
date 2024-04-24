using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2290DegreeRedBlock : MonoBehaviour
{
    public GameObject RedBlock;
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

        if (RotateTime >= 0 && RotateTime < 2)
        {
            RedBlock.transform.Rotate(0, 0, 45 * Time.deltaTime, Space.Self);
        }
        if (RotateTime >= 6 && RotateTime < 8)
        {
            RedBlock.transform.Rotate(0, 0, -45 * Time.deltaTime, Space.Self);
        }
        if (RotateTime > 12)
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
