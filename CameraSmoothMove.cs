using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, -10);
    }

    // Update is called once per frame
    void Update()
    {
        if (MenuDownMove.CameraMovingbool == true)
        {
            if (Ball.BallPositionUp == true)
            {
                Vector3 target = new Vector3(0, 3, -10);
                transform.position = Vector3.Lerp(transform.position, target, 2.5f * Time.deltaTime);
            }
            if (Ball.BallPositionMiddle == true)
            {
                Vector3 target = new Vector3(0, 0, -10);
                transform.position = Vector3.Lerp(transform.position, target, 2.5f * Time.deltaTime);
            }
            if (Ball.BallPositionDown == true)
            {
                Vector3 target = new Vector3(0, -3, -10);
                transform.position = Vector3.Lerp(transform.position, target, 2.5f * Time.deltaTime);
            }
        }
        if (MenuDownMove.CameraMovingbool == false)
        {
            Vector3 target = new Vector3(0, 0, -10);
            transform.position = target;
        }
    }
}
