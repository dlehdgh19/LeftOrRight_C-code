using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearTurnWithLeftArrow : MonoBehaviour
{
    private float SpinSpeedfloat;

    // Start is called before the first frame update
    void Start()
    {
        SpinSpeedfloat = 120;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey (KeyCode.LeftArrow) && WhenLevelStart.HintBool == false && Ball.Deadbool == false && Ball.Entrancebool == false)
        {
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * SpinSpeedfloat));
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && WhenLevelStart.HintBool == false && Ball.Deadbool == false && Ball.Entrancebool == false)
        {
            transform.Rotate(new Vector3(0, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow) && WhenLevelStart.HintBool == false && Ball.Deadbool == false && Ball.Entrancebool == false)
        {
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * -SpinSpeedfloat));
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && WhenLevelStart.HintBool == false && Ball.Deadbool == false && Ball.Entrancebool == false)
        {
            transform.Rotate(new Vector3(0, 0, 0));
        }
    }
}
