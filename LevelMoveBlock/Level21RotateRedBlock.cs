using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level21RotateRedBlock : MonoBehaviour
{
    public GameObject RedBlock;
    public float RotateSpeed;
    private float RotateTime = 0;
    private float Rotate_Z;

    // Start is called before the first frame update
    void Start()
    {
        Rotate_Z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RedBlock.transform.Rotate(0, 0, RotateSpeed * Time.deltaTime);
    }
}
