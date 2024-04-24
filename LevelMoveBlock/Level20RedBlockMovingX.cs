using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level20RedBlockMovingX : MonoBehaviour
{
    public GameObject RedBlock;
    public float Speed;
    private float MovingTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovingTime += Time.deltaTime;
        if(RedBlock.transform.localPosition.x <= - 7)
        {
            RedBlock.transform.localPosition = new Vector3(7, 0, 0);
        }
        if(RedBlock.transform.localPosition.x > -7 && RedBlock.transform.localPosition.x <= 7)
        {
            RedBlock.transform.Translate(Vector3.right * (-Speed) * Time.deltaTime, Space.Self);
        }
    }
}
