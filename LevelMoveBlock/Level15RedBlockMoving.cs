using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level15RedBlockMoving : MonoBehaviour
{
    public GameObject RedBlock;
    public float MovingTime;
    public float Speed;
    private float MoveTime;
    private Vector3 FirstVec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        MoveTime += Time.deltaTime;
        if(MoveTime > 0 && MoveTime < MovingTime)
        {
            RedBlock.transform.Translate(new Vector3(Speed * Time.deltaTime, 0, 0), Space.Self);
        }
        if (MoveTime >= MovingTime && MoveTime < 2 * MovingTime)
        {
            RedBlock.transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0), Space.Self);
        }
        if (MoveTime >= 2 * MovingTime)
        {
            MoveTime = 0;
        }
    }

    private void OnEnable()
    {
        FirstVec = RedBlock.transform.localPosition;
        MoveTime = 0;

    }
    private void OnDisable()
    {
        RedBlock.transform.localPosition = FirstVec;
        MoveTime = 0;

    }
}
