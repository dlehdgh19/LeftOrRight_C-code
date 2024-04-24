using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level25LeftRightRedBlockMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LeftBlock;
    public GameObject RightBlock;
    private float MovingTime = 0;

    public static bool FirstSpawnbool = false;
    public static bool SeceondSpawnbool = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovingTime += Time.deltaTime;

        if(MovingTime > 0f && MovingTime < 20f)
        {
            FirstSpawnbool = true;
            LeftBlock.transform.localPosition = new Vector3(-2.5f, 0, 0);
            RightBlock.transform.localPosition = new Vector3(2.5f, 0, 0);
        }
        if (MovingTime >= 20f && MovingTime < 30f)
        {
            LeftBlock.transform.localPosition = new Vector3(-2.5f - ((MovingTime - 20) * 0.1f), 0, 0);
            RightBlock.transform.localPosition = new Vector3(2.5f + ((MovingTime - 20) * 0.1f), 0, 0);
        }
        if (MovingTime >= 30f && MovingTime < 50f)
        {
            FirstSpawnbool = false;
            SeceondSpawnbool = true;
            LeftBlock.transform.localPosition = new Vector3(-3.5f, 0, 0);
            RightBlock.transform.localPosition = new Vector3(3.5f, 0, 0);
        }
        if (MovingTime >= 50f && MovingTime < 60f)
        {
            LeftBlock.transform.localPosition = new Vector3(-3.5f - ((MovingTime - 50) * 0.3f), 0, 0);
            RightBlock.transform.localPosition = new Vector3(3.5f + ((MovingTime - 50) * 0.3f), 0, 0);
        }
        if (MovingTime >= 60f)
        {
            SeceondSpawnbool = false;
        }

    }
    private void OnEnable()
    {
        LeftBlock.transform.localPosition = new Vector3(-2.5f, 0, 0);
        RightBlock.transform.localPosition = new Vector3(2.5f, 0, 0);
        FirstSpawnbool = false;
        SeceondSpawnbool = false;
        MovingTime = 0;
    }

    private void OnDisable()
    {
        FirstSpawnbool = false;
        SeceondSpawnbool = false;
        MovingTime = 0;
    }
}
