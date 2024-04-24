using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSoundManager : MonoBehaviour
{
    public GameObject LeftGearSound;
    public GameObject RightGearSound;
    // Start is called before the first frame update
    void Start()
    {
        LeftGearSound.SetActive(false);
        RightGearSound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(MapControl.LeftGearSoundbool == true && MenuDownMove.Pausebool == false)
        {
            LeftGearSound.SetActive(true);
        }
        if ((MapControl.LeftGearSoundbool == false && MenuDownMove.Pausebool == false) || Ball.Deadbool == true || Ball.Entrancebool == true || WhenLevelStart.SuccessToChooseLevelMenuBool == true)
        {
            LeftGearSound.SetActive(false);
        }
        if (MapControl.RightGearSoundbool == true && MenuDownMove.Pausebool == false)
        {
            RightGearSound.SetActive(true);
        }
        if (MapControl.RightGearSoundbool == false && MenuDownMove.Pausebool == false || Ball.Deadbool == true || Ball.Entrancebool == true || WhenLevelStart.SuccessToChooseLevelMenuBool == true)
        {
            RightGearSound.SetActive(false);
        }

        if((Input.GetKey(KeyCode.RightArrow) && (Input.GetKey(KeyCode.LeftArrow))) || Ball.Entrancebool == true)
        {
            LeftGearSound.SetActive(false);
            RightGearSound.SetActive(false);
        }
    }
}
