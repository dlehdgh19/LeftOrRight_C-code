using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchToOpenGate : MonoBehaviour
{
    
    public GameObject Border;
    public float MovingScale_x;
    public float MovingScale_y;
    private float MovingTime;
    public float MoveTime;
    private bool Openingbool;
    public GameObject KeyAudio;

    private float RemeberFloatX;
    private float RemeberFloatY;
    private float RemeberFloatTime;
    private Vector3 FirstPostion;
    public static bool WhenGetKeyTurnbool = false;
    private bool AlreadyGetKeybool = false;

    public SpriteRenderer SR;

    // Start is called before the first frame update
    void Start()
    {
        KeyAudio.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Openingbool == true)
        {
            MovingTime += Time.deltaTime;
            if(MovingTime > 0 && MovingTime < MoveTime)
            {
                KeyAudio.SetActive(true);
                Border.transform.Translate(new Vector3(MovingScale_x, MovingScale_y, 0) * Time.deltaTime);
                SR.material.color = new Color(SR.material.color.r, SR.material.color.g, SR.material.color.b, 1 - (MovingTime / 2));
                
            }
            if(MovingTime >= 1f)
            {
                KeyAudio.SetActive(false);
            }
            
        }

        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            if(AlreadyGetKeybool == false)
            {
                Openingbool = true;
                WhenGetKeyTurnbool = true;
            }
            if (AlreadyGetKeybool == true)
            {
                WhenGetKeyTurnbool = false;
            }
        }
    }

    private void OnEnable()
    {
        SR.material.color = new Color(SR.material.color.r, SR.material.color.g, SR.material.color.b, 1);
        FirstPostion = Border.transform.localPosition;
        AlreadyGetKeybool = false;
        WhenGetKeyTurnbool = false;
        KeyAudio.SetActive(false);
    }

    private void OnDisable()
    {
        AlreadyGetKeybool = false;
        WhenGetKeyTurnbool = false;
        Openingbool = false;
        MovingTime = 0;
        Border.transform.localPosition = FirstPostion;
        KeyAudio.SetActive(false);
    }
}
