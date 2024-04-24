using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level10BlockMoveRight : MonoBehaviour
{
    public GameObject MovingBlock;
    public float Speed;
    public float Distance;
    private float Movingfloat;
    private Vector3 FirstPosition;
    // Start is called before the first frame update
    void Start()
    {
        Movingfloat = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Movingfloat += Speed * Time.deltaTime;
        if(Movingfloat > 0 && Movingfloat < Distance)
        {
            MovingBlock.transform.localPosition = new Vector3(FirstPosition.x + Movingfloat, MovingBlock.transform.localPosition.y, 0);
        }
        if(Movingfloat >= Distance)
        {
            Movingfloat = 0;
        }
    }

    private void OnEnable()
    {
        FirstPosition = MovingBlock.transform.localPosition;
    }
    private void OnDisable()
    {
        MovingBlock.transform.localPosition = FirstPosition;
    }
}
