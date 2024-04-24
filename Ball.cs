using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private float fadefloat;
    public static bool Entrancebool = false;

    private float FadeTime;
    private SpriteRenderer myMat;
    private Vector2 vec;
    private Vector3 FirstVec;
    public GameObject Portal;
    private Rigidbody2D rb;
    public static bool BallPositionUp;
    public static bool BallPositionMiddle;
    public static bool BallPositionDown;

    private bool AddForcebool = false;
    private float AddForceTime = 0;
    private bool StrongForcebool = false;
    private bool MiddleForcebool = false;

    public static bool Deadbool = false;
    private Vector3 DeadPosition;

    public static bool Itembool = false;

    // Start is called before the first frame update
    void Start()
    {
        fadefloat = 1;
        FadeTime = 0;
        myMat = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        BallPositionUp = false;
        BallPositionMiddle = false;
        BallPositionDown = false;
        AddForcebool = false;
        StrongForcebool = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Entrancebool == true)
        {
            FadeTime += Time.deltaTime;
            if(FadeTime > 0 && FadeTime <= 1f)
            {
                AddForcebool = false;
                AddForceTime = 0;
                myMat.color = new Color(1, 1, 1, 1 - FadeTime);
                rb.gravityScale = 0;
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
                transform.position = Vector3.Lerp(transform.position, Portal.transform.position, 25f * Time.deltaTime);
            }
        }
        if(Deadbool == true)
        {
            FadeTime += Time.deltaTime;
            if (FadeTime > 0 && FadeTime <= 1f)
            {
                AddForcebool = false;
                AddForceTime = 0;
                myMat.color = new Color(1, 1, 1, 1 - FadeTime);
                gameObject.transform.Rotate(new Vector3(0, 0, 0));
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
                transform.position = DeadPosition;
            }
        }

        if (gameObject.transform.position.y >= 3f)
        {
            BallPositionUp = true;
            BallPositionMiddle = false;
            BallPositionDown = false;
        }
        if (gameObject.transform.position.y < 3f && gameObject.transform.position.y > -3f)
        {
            BallPositionUp = false;
            BallPositionMiddle = true;
            BallPositionDown = false;
        }
        if (gameObject.transform.position.y <= -3f)
        {
            BallPositionUp = false;
            BallPositionMiddle = false;
            BallPositionDown = true;
        }

        if(AddForcebool == true)
        {
            AddForceTime += Time.deltaTime;
            if(AddForceTime > 0 && AddForceTime < 1.7)
            {
                rb.AddForce(Vector3.up * 1700 * Time.deltaTime, ForceMode2D.Force);
            }
            if(AddForceTime >= 1.7f)
            {
                AddForcebool = false;
                AddForceTime = 0;
            }
        }

        if(StrongForcebool == true)
        {
            rb.AddForce(Vector3.up * 2500 * Time.deltaTime, ForceMode2D.Force);
        }
        if(MiddleForcebool == true)
        {
            rb.AddForce(Vector3.up * 2100 * Time.deltaTime, ForceMode2D.Force);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Entrance")
        {
            Entrancebool = true;
        }
        if(other.gameObject.tag == "DeadZone")
        {
            DeadPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            StrongForcebool = false;
            AddForcebool = false;
            MiddleForcebool = false;
            Deadbool = true;

        }
        if (other.gameObject.tag == "AddForceZone")
        {
            AddForcebool = true;

        }
        if (other.gameObject.tag == "StrongForceZone")
        {
            StrongForcebool = true;

        }
        if (other.gameObject.tag == "NormalForceZone")
        {
            StrongForcebool = false;
            MiddleForcebool = false;
        }
        if (other.gameObject.tag == "MiddleForceZone")
        {
            MiddleForcebool = true;
        }
        
    }

    private void OnEnable()
    {
        FirstVec = gameObject.transform.position;
        gameObject.transform.position = new Vector3(FirstVec.x, FirstVec.y, FirstVec.z);
        gameObject.GetComponent<CircleCollider2D>().enabled = true;

        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1.5f;

        myMat = GetComponent<SpriteRenderer>();
        myMat.color = new Color(1, 1, 1, 1);

        BallPositionUp = false;
        BallPositionMiddle = false;
        BallPositionDown = false;

        Entrancebool = false;
        fadefloat = 1;
        FadeTime = 0;

        AddForcebool = false;
        StrongForcebool = false;
        MiddleForcebool = false;
        Deadbool = false;
    }

    private void OnDisable()
    {
        gameObject.transform.position = new Vector3(FirstVec.x, FirstVec.y, FirstVec.z);
        AddForcebool = false;
        StrongForcebool = false;
        MiddleForcebool = false;
        Deadbool = false;
    }
}
