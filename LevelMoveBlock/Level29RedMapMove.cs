using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level29RedMapMove : MonoBehaviour
{
    private float MoveTime = 0;
    public float Speed;
    public static bool NextStepbool = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTime += Time.deltaTime;
        
        if(MoveTime > 0 && MoveTime < 46.4f)
        {
            this.transform.position = new Vector3(58 - Speed * MoveTime, 0, 0);
        }
        if (MoveTime > 46.4f && MoveTime < 92.8f)
        {
            this.transform.rotation = Quaternion.Euler(0, 0, -90);
            this.transform.position = new Vector3(0, 58 - Speed * (MoveTime - 46.4f), 0);
        }
        if(MoveTime > 92.8)
        {
            NextStepbool = true;
        }

    }

    private void OnEnable()
    {
        MoveTime = 0;
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
        this.transform.position = new Vector3(58, 0, 0);
        NextStepbool = false;
        MoveTime = 0;
    }

    private void OnDisable()
    {
        MoveTime = 0;
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
        this.transform.position = new Vector3(58, 0, 0);
        NextStepbool = false;
    }
}
