using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuDownMove : MonoBehaviour
{
    [SerializeField]
    private float MovingTerm;

    [SerializeField]
    private float Speed;

    [SerializeField]
    private float EndTick;

    [SerializeField]
    private GameObject MainMenuCanvas;

    [SerializeField]
    private GameObject ChooseLevelCanvas;

    [SerializeField]
    private GameObject SettingCanvas;

    [SerializeField]
    private GameObject HowToPlayCanvas;

    [SerializeField]
    private GameObject BackGroundGears1;

    [SerializeField]
    private GameObject BackGroundGears2;

    [SerializeField]
    private GameObject PauseButtonCanvas;

    [SerializeField]
    private GameObject PauseCanvas;

    [SerializeField]
    private GameObject[] Levels;

    [SerializeField]
    private GameObject[] Maps;

    [SerializeField]
    private GameObject[] Balls;

    [SerializeField]
    private GameObject MainBGM;

    [SerializeField]
    private GameObject LevelBGM;

    [SerializeField]
    private AudioSource ButtonAudio;


    private float Moving;
    private float timeEnd;
    private float PlayGametime;

    private bool MainMenubool = true;
    private bool FirstMainbool = false;
    private bool HowtoPlaybool = false;
    private bool Settingbool = false;
    private bool ChooseLevelbool = false;
    public static bool ChosenLevelbool = false;
    public static bool PauseToChooseLevelbool = false;
    public static bool Pausebool = false;

    private int LevelPageInt = 1;
    public Text LevelText1;
    public Text LevelText2;
    public Text LevelText3;
    private int LevelLeftInt;
    private int LevelMiddleInt;
    private int LevelRightInt;
    public static int FinalInt = 0;
    private float Deadfloat = 0;
    public static bool HintCanvasAppearbool;

    public static bool CameraMovingbool = false;
    void Start()
    {
        timeEnd = 0;
        Moving = 0;
        
        PlayGametime = 0;
        MainMenuCanvas.SetActive(false);
        ChooseLevelCanvas.SetActive(false);
        SettingCanvas.SetActive(false);
        HowToPlayCanvas.SetActive(false);
        BackGroundGears1.SetActive(true);
        BackGroundGears2.SetActive(false);
        PauseCanvas.SetActive(false);
        PauseButtonCanvas.SetActive(false);
        HintCanvasAppearbool = false;

        MainBGM.SetActive(false);
        LevelBGM.SetActive(false);
        
    }
    private void Update()
    {
        LevelPage();

        if(WhenLevelStart.SuccessToChooseLevelMenuBool == true)
        {
            WhenSuccessLevelToSelectMenuButtonClick();
            WhenLevelStart.SuccessToChooseLevelMenuBool = false;
        }

        if (MainMenubool == true && FirstMainbool == false)
        {
            timeEnd += Time.deltaTime;
            if (timeEnd > 0 && timeEnd < EndTick)
            {
                MainBGM.SetActive(true);
                Moving += Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            if (timeEnd >= EndTick)
            {
                transform.position = new Vector3(-3.691025f, 0, 0f);
                MainMenuCanvas.SetActive(true);
            }
        }

        if (MainMenubool == true && FirstMainbool == true)
        {
            timeEnd += Time.deltaTime;
            if (timeEnd > 0 && timeEnd < EndTick)
            {
                Moving -= Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            if (timeEnd >= EndTick + 1 && timeEnd < 2 * EndTick + 1)
            {
                Moving += Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            if (timeEnd >= 2 * EndTick + 1)
            {
                Moving = 2.12f;
                transform.position = new Vector3(-3.691025f, 0, 0f);
                MainMenuCanvas.SetActive(true);
            }
        }

        if (ChooseLevelbool == true)
        {
            timeEnd += Time.deltaTime;
            if (timeEnd > 0 && timeEnd < EndTick)
            {
                Moving -= Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            if (timeEnd >= EndTick + 1 && timeEnd < 2 * EndTick + 1)
            {
                Moving += Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            if (timeEnd >= 2 * EndTick + 1)
            {
                Moving = 2.12f;
                transform.position = new Vector3(-3.691025f, 0, 0f);
                ChooseLevelCanvas.SetActive(true);
                ChooseLevelbool = false;
            }
        }

        if (Settingbool == true)
        {
            timeEnd += Time.deltaTime;
            if (timeEnd > 0 && timeEnd < EndTick)
            {
                Moving -= Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            if (timeEnd >= EndTick + 1 && timeEnd < 2 * EndTick + 1)
            {
                Moving += Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            if (timeEnd >= 2 * EndTick + 1)
            {
                Moving = 2.12f;
                transform.position = new Vector3(-3.691025f, 0, 0f);
                SettingCanvas.SetActive(true);
            }
        }

        if (HowtoPlaybool == true)
        {
            timeEnd += Time.deltaTime;
            if (timeEnd > 0 && timeEnd < EndTick)
            {
                Moving -= Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            if (timeEnd >= EndTick + 1 && timeEnd < 2 * EndTick + 1)
            {
                Moving += Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            if (timeEnd >= 2 * EndTick + 1)
            {
                Moving = 2.12f;
                transform.position = new Vector3(-3.691025f, 0, 0f);
                HowToPlayCanvas.SetActive(true);
            }
        }

        if (PauseToChooseLevelbool == true)
        {
            timeEnd += Time.deltaTime;
            if (timeEnd > 0 && timeEnd < EndTick)
            {
                MainBGM.SetActive(true);
                Moving += Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            if (timeEnd >= EndTick)
            {
                Moving = 2.12f;
                transform.position = new Vector3(-3.691025f, 0, 0f);
                ChooseLevelCanvas.SetActive(true);
                PauseToChooseLevelbool = false;
            }
        }

        if (ChosenLevelbool == true)
        {
            timeEnd += Time.deltaTime;
            if (timeEnd > 0 && timeEnd < EndTick)
            {
                Moving -= Speed * Time.deltaTime;
                transform.position = new Vector3(-3.691025f, 14 + Mathf.Sin(-Moving) * MovingTerm, 0f);
            }
            
            if (timeEnd >= EndTick + 1)
            {
                CameraMovingbool = true;
                Moving = 0;
                LevelBGM.SetActive(true);
                BackGroundGears1.SetActive(false);
                BackGroundGears2.SetActive(true);
                Levels[FinalInt - 1].SetActive(true);
                Maps[FinalInt - 1].SetActive(true);
                Balls[FinalInt - 1].SetActive(true);
                PauseButtonCanvas.SetActive(true);
                HintCanvasAppearbool = true;
                ChosenLevelbool = false;
            }
        }

        if(Ball.Deadbool == true)
        {
            Deadfloat += Time.deltaTime;
            if(Deadfloat > 0 && Deadfloat < 1.5f)
            {

            }
            if(Deadfloat >= 1.5f)
            {
                Levels[FinalInt - 1].SetActive(false);
                Maps[FinalInt - 1].SetActive(false);
                Balls[FinalInt - 1].SetActive(false);
                Levels[FinalInt - 1].SetActive(true);
                Maps[FinalInt - 1].SetActive(true);
                Balls[FinalInt - 1].SetActive(true);
                Ball.Deadbool = false;
                Deadfloat = 0;
            }
        }

        if(WhenLevelStart.SuccessfullyGoToNextLevelBool == true)
        {
            Levels[FinalInt - 1].SetActive(false);
            Maps[FinalInt - 1].SetActive(false);
            Balls[FinalInt - 1].SetActive(false);

            FinalInt += 1;

            Levels[FinalInt - 1].SetActive(true);
            Maps[FinalInt - 1].SetActive(true);
            Balls[FinalInt - 1].SetActive(true);

            WhenLevelStart.SuccessfullyGoToNextLevelBool = false;
            HintCanvasAppearbool = true;
        }
    }


    // ButtonClickEvent Below ------------------------------------------------------------------------------------------

    public void GameStartButton()
    {
        ButtonAudio.Play();
        MainMenubool = false;
        MainMenuCanvas.SetActive(false);
        timeEnd = 0;
        ChooseLevelbool = true;
    }

    public void SelectLevelPagetoMainMenuButton()
    {
        ButtonAudio.Play();
        FirstMainbool = true;
        MainMenubool = true;
        ChooseLevelCanvas.SetActive(false);
        timeEnd = 0;
        ChooseLevelbool = false;
    }
    public void SettingButton()
    {
        ButtonAudio.Play();
        MainMenubool = false;
        MainMenuCanvas.SetActive(false);
        timeEnd = 0;
        Settingbool = true;
    }    

    public void SettingToMainMenuButton()
    {
        ButtonAudio.Play();
        FirstMainbool = true;
        MainMenubool = true;
        SettingCanvas.SetActive(false);
        timeEnd = 0;
        Settingbool = false;
    }

    public void HowToPlayButton()
    {
        ButtonAudio.Play();
        MainMenubool = false;
        MainMenuCanvas.SetActive(false);
        timeEnd = 0;
        HowtoPlaybool = true;
    }

    public void HowToPlayToMainMenuButton()
    {
        ButtonAudio.Play();
        FirstMainbool = true;
        MainMenubool = true;
        HowToPlayCanvas.SetActive(false);
        timeEnd = 0;
        HowtoPlaybool = false;
    }
    public void ExitButton()
    {
        ButtonAudio.Play();
        Application.Quit();
    }

    public void LevelIntUp()
    {
        ButtonAudio.Play();
        if (LevelPageInt >= 1 && LevelPageInt <= 9)
        {
            LevelPageInt += 1;
        }
    }

    public void LevelIntDown()
    {
        ButtonAudio.Play();
        if (LevelPageInt >= 2 && LevelPageInt <= 10)
        {
            LevelPageInt -= 1;
        }
    }

    public void SelectLevelButton1()
    {
        if(LevelLeftInt == ((LevelPageInt - 1) * 3 + 1))
        {
            ButtonAudio.Play();
            MainBGM.SetActive(false);
            ChooseLevelbool = false;
            FinalInt = LevelLeftInt;
            ChooseLevelCanvas.SetActive(false);
            timeEnd = 0;
            ChosenLevelbool = true;
            
            //update()에서 panel 위로 올라가고 레벨에 따른 맵 소환
        }
    }

    public void SelectLevelButton2()
    {
        if (LevelMiddleInt == ((LevelPageInt - 1) * 3 + 2))
        {
            ButtonAudio.Play();
            MainBGM.SetActive(false);
            ChooseLevelbool = false;
            FinalInt = LevelMiddleInt;
            ChooseLevelCanvas.SetActive(false);
            timeEnd = 0;
            ChosenLevelbool = true;
            
            //update()에서 panel 위로 올라가고 레벨에 따른 맵 소환
        }
    }

    public void SelectLevelButton3()
    {
        if (LevelRightInt == ((LevelPageInt - 1) * 3 + 3))
        {
            ButtonAudio.Play();
            MainBGM.SetActive(false);
            ChooseLevelbool = false;
            FinalInt = LevelRightInt;
            ChooseLevelCanvas.SetActive(false);
            timeEnd = 0;
            ChosenLevelbool = true;
            
            //update()에서 panel 위로 올라가고 레벨에 따른 맵 소환
        }
    }

    public void PauseButton()
    {
        Pausebool = true;
        // 게임 pause되고, 일시정지 화면 띄우기, 일시정지화면에는 단계선택화면 갈 수 있고, resume 버튼 구현, 
        Time.timeScale = 0;
        PauseCanvas.SetActive(true);
    }

    public void ResumeButton()
    {
        Pausebool = false;
        Time.timeScale = 1;
        PauseCanvas.SetActive(false);
    }

    public void ChosenLevelToSelectMenuButton()
    {
        CameraMovingbool = false;
        ButtonAudio.Play();
        Pausebool = false;
        LevelBGM.SetActive(false);
        Time.timeScale = 1;
        ChosenLevelbool = false;
        PauseCanvas.SetActive(false);
        BackGroundGears1.SetActive(true);
        BackGroundGears2.SetActive(false);
        PauseButtonCanvas.SetActive(false);
        HintCanvasAppearbool = false;
        Levels[FinalInt - 1].SetActive(false);
        Maps[FinalInt - 1].SetActive(false);
        Balls[FinalInt - 1].SetActive(false);
        FinalInt = 0;
        timeEnd = 0;
        PauseToChooseLevelbool = true;
        
    }

    private void WhenSuccessLevelToSelectMenuButtonClick()
    {
        CameraMovingbool = false;
        ButtonAudio.Play();
        Pausebool = false;
        LevelBGM.SetActive(false);
        Time.timeScale = 1;
        ChosenLevelbool = false;
        PauseCanvas.SetActive(false);
        BackGroundGears1.SetActive(true);
        BackGroundGears2.SetActive(false);
        PauseButtonCanvas.SetActive(false);
        HintCanvasAppearbool = false;
        Levels[FinalInt - 1].SetActive(false);
        Maps[FinalInt - 1].SetActive(false);
        Balls[FinalInt - 1].SetActive(false);
        FinalInt = 0;
        timeEnd = 0;
        PauseToChooseLevelbool = true;

    }


    // ButtonClickEvent End ------------------------------------------------------------------------------------------

    private void LevelPage()
    {
        LevelLeftInt = ((LevelPageInt - 1) * 3 + 1);
        LevelMiddleInt = ((LevelPageInt - 1) * 3 + 2);
        LevelRightInt = ((LevelPageInt - 1) * 3 + 3);
        LevelText1.text = ((LevelPageInt - 1) * 3 + 1).ToString();
        LevelText2.text = ((LevelPageInt - 1) * 3 + 2).ToString();
        LevelText3.text = ((LevelPageInt - 1) * 3 + 3).ToString();
    }
}
