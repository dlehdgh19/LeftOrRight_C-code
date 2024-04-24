using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControl : MonoBehaviour
{
    public float SpinSpeedfloat;
    public static bool RightGearSoundbool;
    public static bool LeftGearSoundbool;
    // Start is called before the first frame update
    void Start()
    {
        RightGearSoundbool = false;
        LeftGearSoundbool = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && WhenLevelStart.HintBool == false && Ball.Deadbool == false && Ball.Entrancebool == false)
        {
            LeftGearSoundbool = true;
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * SpinSpeedfloat));
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && WhenLevelStart.HintBool == false && Ball.Deadbool == false && Ball.Entrancebool == false)
        {
            LeftGearSoundbool = false;
            transform.Rotate(new Vector3(0, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow) && WhenLevelStart.HintBool == false && Ball.Deadbool == false && Ball.Entrancebool == false)
        {
            RightGearSoundbool = true;
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * -SpinSpeedfloat));
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && WhenLevelStart.HintBool == false && Ball.Deadbool == false && Ball.Entrancebool == false)
        {
            RightGearSoundbool = false;
            transform.Rotate(new Vector3(0, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow) && (Input.GetKeyUp(KeyCode.LeftArrow) && WhenLevelStart.HintBool == false) && Ball.Deadbool == false && Ball.Entrancebool == false)
        {
            RightGearSoundbool = false;
            LeftGearSoundbool = false;
            transform.Rotate(new Vector3(0, 0, 0));
        }
        if(Ball.Deadbool == true || Ball.Entrancebool == true)
        {
            RightGearSoundbool = false;
            LeftGearSoundbool = false;
        }
    }

    private void OnEnable()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
