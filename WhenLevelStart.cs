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
                SucessLevelText.text = MenuDownMove.FinalInt.ToString() + " 레벨 클리어!";
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
                SucessLevelText.text = "마지막 레벨 클리어!";
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
                    HintText.text = "토튜리얼";
                    break;
                case 2:
                    HintText.text = "여정의 시작";
                    break;
                case 3:
                    HintText.text = "이 앞 함정있다!";
                    break;
                case 4:
                    HintText.text = "11미터에서 떨어지는...";
                    break;
                case 5:
                    HintText.text = "천천히 차근차근";
                    break;
                case 6:
                    HintText.text = "이제 돌아가야지?";
                    break;
                case 7:
                    HintText.text = "문을 열기 위해선?";
                    break;
                case 8:
                    HintText.text = "뺑소니 조심!";
                    break;
                case 9:
                    HintText.text = "뭐야~ 쉽네 ㅋ";
                    break;
                case 10:
                    HintText.text = "타이밍이 중요해!";
                    break;
                case 11:
                    HintText.text = "일시적인 중력반전";
                    break;
                case 12:
                    HintText.text = "엘리베이터";
                    break;
                case 13:
                    HintText.text = "한 걸음, 한 걸음씩";
                    break;
                case 14:
                    HintText.text = "어디로 떨어질까?";
                    break;
                case 15:
                    HintText.text = "왔다리 갔다리 1";
                    break;
                case 16:
                    HintText.text = "사라지는 발판";
                    break;
                case 17:
                    HintText.text = "블 랙 홀";
                    break;
                case 18:
                    HintText.text = "화 이 트 홀";
                    break;
                case 19:
                    HintText.text = "미션 임파서블";
                    break;
                case 20:
                    HintText.text = "왔다리 갔다리 2";
                    break;
                case 21:
                    HintText.text = "3 개의 풍차";
                    break;
                case 22:
                    HintText.text = "피지컬 발휘할 시간";
                    break;
                case 23:
                    HintText.text = "신의 지팡이";
                    break;
                case 24:
                    HintText.text = "탕! 탕! 탕!";
                    break;
                case 25:
                    HintText.text = "동체시력 테스트";
                    break;
                case 26:
                    HintText.text = "오소이...";
                    break;
                case 27:
                    HintText.text = "스포트라이트";
                    break;
                case 28:
                    HintText.text = "안전한 공간 공략";
                    break;
                case 29:
                    HintText.text = "좁은 골목길을 지나";
                    break;
                case 30:
                    HintText.text = "시간을 지배하는 자!";
                    break;
                case 31:
                    HintText.text = "마지막 레벨 클리어";
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
            Startgametext.text = "게 임 시 작";
            Settingtext.text = "설    정";
            BGMtext.text = "배경음";
            Effecttext.text = "효과음";
            HowtoPlaytext.text = "게 임 방 법";
            HowtoPlayExplaintext.text = "오른쪽, 왼쪽 키보드만 이용하세요.\n그리고 공을 목표지점까지 이동시키세요. \n모든 단계를 자유롭게 플레이하실 수 있습니다.\n만약 너무 어렵다면 다른 단계를 즐겨보세요.";
            Languagetext.text = "한국어";
            BackWardtext1.text = "뒤 로 가 기";
            BackWardtext2.text = "뒤 로 가 기";
            BackWardtext3.text = "뒤 로 가 기";
            BackWardtext4.text = "뒤 로 가 기";
            Pausetext.text = "일 시 정 지";
            EndText.text = "게임은 재미있으셨나요?\n여러분이 재미를 느끼셨다면 \n그걸로 저는 OK 입니다. \n추후에 더 좋은 게임으로 돌아오겠습니다.";
            ExitGameText.text = "게 임 종 료";
            Langtext.text = "언  어";
            NextLeveltext.text = "다 음 레 벨 로";
            Resumetext.text = "계 속 하 기";
            ChooseLeveltext.text = "레 벨 선 택";
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
