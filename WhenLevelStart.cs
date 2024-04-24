using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WhenLevelStart : MonoBehaviour
{
    [SerializeField]
    private GameObject HintCanvas;

    [SerializeField]
    private Text HintText;

    [SerializeField]
    private GameObject SucessCanvas;

    [SerializeField]
    private Text SucessLevelText;

    [SerializeField]
    private Animator HintAnim;

    [SerializeField]
    private Animator SuccessAnim;

    [SerializeField]
    private GameObject PauseButton;

    [SerializeField]
    private GameObject When30LevelClearNextButton;

    [SerializeField]
    private GameObject AllClearText;

    public Text Startgametext;
    public Text Settingtext;
    public Text BGMtext;
    public Text Effecttext;
    public Text HowtoPlaytext;
    public Text HowtoPlayExplaintext;
    public Text Languagetext;
    public Text BackWardtext1;
    public Text BackWardtext2;
    public Text BackWardtext3;
    public Text BackWardtext4;
    public Text Pausetext;
    public Text EndText;
    public Text ExitGameText;
    public Text Langtext;
    public Text NextLeveltext;
    public Text Resumetext;
    public Text ChooseLeveltext;


    public static bool HintBool = false;
    private float AfterStartLevelTime = 0;
    private float AfterSuccessLevelTime = 0;
    private bool NextLevelbool = false;
    public static bool SuccessfullyGoToNextLevelBool = false;
    public static bool SuccessToChooseLevelMenuBool = false;

    private int LaguageInt = 0;
    // Start is called before the first frame update
    void Start()
    {
        HintCanvas.SetActive(false);
        SucessCanvas.SetActive(false);
        PauseButton.SetActive(false);
        When30LevelClearNextButton.SetActive(true);
        AllClearText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Lang();
        GetLevelIntFromMenuDownMove();
        if(MenuDownMove.HintCanvasAppearbool == true)
        {
            AfterStartLevelTime += Time.deltaTime;
            if(AfterStartLevelTime > 0 && AfterStartLevelTime <= 2)
            {
                PauseButton.SetActive(false);
                HintBool = true;
                HintCanvas.SetActive(true);
                HintAnim.SetBool("HintAppearBool", true);
            }
            if (AfterStartLevelTime > 2 && AfterStartLevelTime <= 3)
            {
                HintAnim.SetBool("HintDisappearBool", true);
            }
            if (AfterStartLevelTime > 3)
            {
                HintAnim.SetBool("HintAppearBool", false);
                HintAnim.SetBool("HintDisappearBool", false);
                HintCanvas.SetActive(false);
                PauseButton.SetActive(true);
                HintBool = false;
                MenuDownMove.HintCanvasAppearbool = false;
                AfterStartLevelTime = 0;
            }
        }

        if(Ball.Entrancebool == true)
        {
            if(NextLevelbool == false)
            {
                AfterSuccessLevelTime += Time.deltaTime;
                if (AfterSuccessLevelTime > 1 && AfterSuccessLevelTime <= 2)
                {
                    PauseButton.SetActive(false);
                    SucessCanvas.SetActive(true);
                    SuccessAnim.SetBool("SuccessAppearBool", true);
                }
            }
            if (NextLevelbool == true)
            {
                AfterSuccessLevelTime += Time.deltaTime;
                if(AfterSuccessLevelTime > 0 && AfterSuccessLevelTime <= 1)
                {
                    SuccessAnim.SetBool("SuccessDisappearBool", true);
                }
                if (AfterSuccessLevelTime > 1)
                {
                    SuccessAnim.SetBool("SuccessAppearBool", false);
                    SuccessAnim.SetBool("SuccessDisappearBool", false);
                    NextLevelbool = false;
                    AfterSuccessLevelTime = 0;
                    SuccessfullyGoToNextLevelBool = true;
                    Ball.Entrancebool = false;
                    SucessCanvas.SetActive(false);
                }
            }
        }

        if(SuccessToChooseLevelMenuBool == true)
        {
             PauseButton.SetActive(false);
             SuccessAnim.SetBool("SuccessAppearBool", false);
             SuccessAnim.SetBool("SuccessDisappearBool", false);
             NextLevelbool = false;
             AfterSuccessLevelTime = 0;
             Ball.Entrancebool = false;
             SucessCanvas.SetActive(false);
             

        }
    }

    private void GetLevelIntFromMenuDownMove()
    {
        if(MenuDownMove.FinalInt < 30)
        {
            AllClearText.SetActive(false);
            When30LevelClearNextButton.SetActive(true);
            if(LaguageInt == 0)
            {
                SucessLevelText.text = MenuDownMove.FinalInt.ToString() + " ���� Ŭ����!";
            }
            if (LaguageInt == 1)
            {
                SucessLevelText.text = "Level " + MenuDownMove.FinalInt.ToString() + " Clear";
            }
        }
        if (MenuDownMove.FinalInt == 30)
        {
            AllClearText.SetActive(true);
            When30LevelClearNextButton.SetActive(false);
            if (LaguageInt == 0)
            {
                SucessLevelText.text = "������ ���� Ŭ����!";
            }
            if (LaguageInt == 1)
            {
                SucessLevelText.text = "Last Level Clear";
            }
            
        }
        if(LaguageInt == 0)
        {
            switch (MenuDownMove.FinalInt)
            {
                case 1:
                    HintText.text = "��Ʃ����";
                    break;
                case 2:
                    HintText.text = "������ ����";
                    break;
                case 3:
                    HintText.text = "�� �� �����ִ�!";
                    break;
                case 4:
                    HintText.text = "11���Ϳ��� ��������...";
                    break;
                case 5:
                    HintText.text = "õõ�� ��������";
                    break;
                case 6:
                    HintText.text = "���� ���ư�����?";
                    break;
                case 7:
                    HintText.text = "���� ���� ���ؼ�?";
                    break;
                case 8:
                    HintText.text = "���Ҵ� ����!";
                    break;
                case 9:
                    HintText.text = "����~ ���� ��";
                    break;
                case 10:
                    HintText.text = "Ÿ�̹��� �߿���!";
                    break;
                case 11:
                    HintText.text = "�Ͻ����� �߷¹���";
                    break;
                case 12:
                    HintText.text = "����������";
                    break;
                case 13:
                    HintText.text = "�� ����, �� ������";
                    break;
                case 14:
                    HintText.text = "���� ��������?";
                    break;
                case 15:
                    HintText.text = "�Դٸ� ���ٸ� 1";
                    break;
                case 16:
                    HintText.text = "������� ����";
                    break;
                case 17:
                    HintText.text = "�� �� Ȧ";
                    break;
                case 18:
                    HintText.text = "ȭ �� Ʈ Ȧ";
                    break;
                case 19:
                    HintText.text = "�̼� ���ļ���";
                    break;
                case 20:
                    HintText.text = "�Դٸ� ���ٸ� 2";
                    break;
                case 21:
                    HintText.text = "3 ���� ǳ��";
                    break;
                case 22:
                    HintText.text = "������ ������ �ð�";
                    break;
                case 23:
                    HintText.text = "���� ������";
                    break;
                case 24:
                    HintText.text = "��! ��! ��!";
                    break;
                case 25:
                    HintText.text = "��ü�÷� �׽�Ʈ";
                    break;
                case 26:
                    HintText.text = "������...";
                    break;
                case 27:
                    HintText.text = "����Ʈ����Ʈ";
                    break;
                case 28:
                    HintText.text = "������ ���� ����";
                    break;
                case 29:
                    HintText.text = "���� ������ ����";
                    break;
                case 30:
                    HintText.text = "�ð��� �����ϴ� ��!";
                    break;
                case 31:
                    HintText.text = "������ ���� Ŭ����";
                    break;

                default:
                    break;

            }
        }
        if (LaguageInt == 1)
        {
            switch (MenuDownMove.FinalInt)
            {
                case 1:
                    HintText.text = "Toturial";
                    break;
                case 2:
                    HintText.text = "Begin the Journey";
                    break;
                case 3:
                    HintText.text = "Trap!";
                    break;
                case 4:
                    HintText.text = "Down there...";
                    break;
                case 5:
                    HintText.text = "Slowly...";
                    break;
                case 6:
                    HintText.text = "Go back now";
                    break;
                case 7:
                    HintText.text = "Open the door";
                    break;
                case 8:
                    HintText.text = "Watch out!";
                    break;
                case 9:
                    HintText.text = "It's too easy~";
                    break;
                case 10:
                    HintText.text = "Timing is important!";
                    break;
                case 11:
                    HintText.text = "reversal of gravity";
                    break;
                case 12:
                    HintText.text = "Elevator";
                    break;
                case 13:
                    HintText.text = "Step by step";
                    break;
                case 14:
                    HintText.text = "Where to fall?";
                    break;
                case 15:
                    HintText.text = "Back and forth 1";
                    break;
                case 16:
                    HintText.text = "disappearing Ground";
                    break;
                case 17:
                    HintText.text = "Black Hole";
                    break;
                case 18:
                    HintText.text = "White Hole";
                    break;
                case 19:
                    HintText.text = "mission Impossible";
                    break;
                case 20:
                    HintText.text = "Back and forth 2";
                    break;
                case 21:
                    HintText.text = "3 windmills";
                    break;
                case 22:
                    HintText.text = "Too hard for you?";
                    break;
                case 23:
                    HintText.text = "God's wand";
                    break;
                case 24:
                    HintText.text = "Bang! Bang! Bang!";
                    break;
                case 25:
                    HintText.text = "Look closely";
                    break;
                case 26:
                    HintText.text = "Avoid it!";
                    break;
                case 27:
                    HintText.text = "Spotlights";
                    break;
                case 28:
                    HintText.text = "Find safe place";
                    break;
                case 29:
                    HintText.text = "Narrow road";
                    break;
                case 30:
                    HintText.text = "Controlling time";
                    break;
                case 31:
                    HintText.text = "Last Level Clear";
                    break;

                default:
                    break;

            }
        }

        if(LaguageInt == 2)
        {
            LaguageInt = 0;
        }
    }

    public void NextLevelButton()
    {
        AfterSuccessLevelTime = 0;
        NextLevelbool = true;

    }

    public void SuccessToChooseButton()
    {
        AllClearText.SetActive(false);
        When30LevelClearNextButton.SetActive(true);
        AfterSuccessLevelTime = 0;
        SuccessToChooseLevelMenuBool = true;
    }

    public void ChangeLanguageButton()
    {
        LaguageInt += 1;
    }

    private void Lang()
    {
        if(LaguageInt == 0)
        {
            Startgametext.text = "�� �� �� ��";
            Settingtext.text = "��    ��";
            BGMtext.text = "�����";
            Effecttext.text = "ȿ����";
            HowtoPlaytext.text = "�� �� �� ��";
            HowtoPlayExplaintext.text = "������, ���� Ű���常 �̿��ϼ���.\n�׸��� ���� ��ǥ�������� �̵���Ű����. \n��� �ܰ踦 �����Ӱ� �÷����Ͻ� �� �ֽ��ϴ�.\n���� �ʹ� ��ƴٸ� �ٸ� �ܰ踦 ��ܺ�����.";
            Languagetext.text = "�ѱ���";
            BackWardtext1.text = "�� �� �� ��";
            BackWardtext2.text = "�� �� �� ��";
            BackWardtext3.text = "�� �� �� ��";
            BackWardtext4.text = "�� �� �� ��";
            Pausetext.text = "�� �� �� ��";
            EndText.text = "������ ��������̳���?\n�������� ��̸� �����̴ٸ� \n�װɷ� ���� OK �Դϴ�. \n���Ŀ� �� ���� �������� ���ƿ��ڽ��ϴ�.";
            ExitGameText.text = "�� �� �� ��";
            Langtext.text = "��  ��";
            NextLeveltext.text = "�� �� �� �� ��";
            Resumetext.text = "�� �� �� ��";
            ChooseLeveltext.text = "�� �� �� ��";
        }

        if (LaguageInt == 1)
        {
            Startgametext.text = "GameStart";
            Settingtext.text = "Setting";
            BGMtext.text = "B G M";
            Effecttext.text = "S F X";
            HowtoPlaytext.text = "How to play";
            HowtoPlayExplaintext.text = "Use only Right, Left Keyboard Buttons.\nMove the ball to the target.\nYou can play all stage no mater what.\nso choose stage whatever you want!";
            Languagetext.text = "Eng";
            BackWardtext1.text = "BackSpace";
            BackWardtext2.text = "BackSpace";
            BackWardtext3.text = "BackSpace";
            BackWardtext4.text = "BackSpace";
            Pausetext.text = "Pause";
            EndText.text = "Enjoy the game?\nIf you enjoyed it,\nthat's enough for me. \nI'll be back with a better game.";
            ExitGameText.text = "ExitGame";
            Langtext.text = "LANG";
            NextLeveltext.text = "Go to next level";
            Resumetext.text = "Resume";
            ChooseLeveltext.text = "Choose level";
        }
    }
}
