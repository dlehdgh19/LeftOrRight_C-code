using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level24GunShots : MonoBehaviour
{
    public GameObject GunShot1;
    public GameObject GunShot2;
    public GameObject GunShot3;
    public SpriteRenderer TargetColor1;
    public SpriteRenderer TargetColor2;
    public SpriteRenderer TargetColor3;
    public GameObject DeadlyGun1;
    public GameObject DeadlyGun2;
    public GameObject DeadlyGun3;
    private float ShootTime = 0;
    private Vector3 FirstPosition1;
    private Vector3 FirstPosition2;
    private Vector3 FirstPosition3;
    private Vector3 LastPosition1;
    private Vector3 LastPosition2;
    private Vector3 LastPosition3;
    public GameObject Ball;
    public GameObject TargetSound1;
    public GameObject TargetSound2;
    public GameObject TargetSound3;
    public GameObject ShootSound1;
    public GameObject ShootSound2;
    public GameObject ShootSound3;

    Vector3 velo = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootTime += Time.deltaTime;
        if(ShootTime >= 0 && ShootTime < 2)
        {
            TargetColor1.color = new Color(0, 1, 0, 0.75f);
            TargetColor2.color = new Color(0, 1, 0, 0.75f);
            TargetColor3.color = new Color(0, 1, 0, 0.75f);
            GunShot1.transform.localPosition = FirstPosition1;
            GunShot2.transform.localPosition = FirstPosition2;
            GunShot3.transform.localPosition = FirstPosition3;
        }
        if(ShootTime >= 2 && ShootTime < 4)
        {
            TargetColor1.color = new Color(0, 1, 0, 0.75f);
            TargetColor2.color = new Color(0, 1, 0, 0.75f);
            TargetColor3.color = new Color(0, 1, 0, 0.75f);
            GunShot1.transform.localPosition = Vector3.Lerp(LastPosition1, Ball.transform.localPosition, 6f * Time.deltaTime);
            GunShot2.transform.localPosition = Vector3.Lerp(LastPosition2, Ball.transform.localPosition, 6f * Time.deltaTime);
            GunShot3.transform.localPosition = Vector3.Lerp(LastPosition3, Ball.transform.localPosition, 6f * Time.deltaTime);

            LastPosition1 = GunShot1.transform.localPosition;
            LastPosition2 = GunShot2.transform.localPosition;
            LastPosition3 = GunShot3.transform.localPosition;
        }
        if(ShootTime > 4 && ShootTime < 4.3f)
        {
            GunShot1.transform.localPosition = LastPosition1;
            TargetColor1.color = new Color(1, 0.5f, 0, 0.75f);
            TargetSound1.SetActive(true);

            GunShot2.transform.localPosition = Vector3.Lerp(LastPosition2, Ball.transform.localPosition, 6f * Time.deltaTime);
            GunShot3.transform.localPosition = Vector3.Lerp(LastPosition3, Ball.transform.localPosition, 6f * Time.deltaTime);
            LastPosition2 = GunShot2.transform.localPosition;
            LastPosition3 = GunShot3.transform.localPosition;
        }
        if (ShootTime > 4.3f && ShootTime < 4.6f)
        {
            GunShot2.transform.localPosition = LastPosition2;
            TargetColor2.color = new Color(1, 0.5f, 0, 0.75f);
            TargetSound2.SetActive(true);

            GunShot3.transform.localPosition = Vector3.Lerp(LastPosition3, Ball.transform.localPosition, 6f * Time.deltaTime);
            LastPosition3 = GunShot3.transform.localPosition;
        }
        if (ShootTime > 4.6f && ShootTime < 4.9f)
        {
            GunShot3.transform.localPosition = LastPosition3;
            TargetColor3.color = new Color(1, 0.5f, 0, 0.75f);
            TargetSound3.SetActive(true);
        }
        if (ShootTime > 5.2f && ShootTime < 5.5f)
        {
            ShootSound1.SetActive(true);
            DeadlyGun1.SetActive(true);

        }
        if (ShootTime > 5.5f && ShootTime < 5.8f)
        {
            ShootSound2.SetActive(true);
            DeadlyGun2.SetActive(true);
        }
        if (ShootTime > 5.8f && ShootTime < 6.1f)
        {
            ShootSound3.SetActive(true);
            DeadlyGun3.SetActive(true);
        }
        
        if (ShootTime > 6.4f && ShootTime < 6.7f)
        {
            TargetColor1.color = new Color(0, 0, 0, 0f);
            DeadlyGun1.SetActive(false);
            ShootSound1.SetActive(false);
        }
        if (ShootTime > 6.7f && ShootTime < 7f)
        {
            TargetColor2.color = new Color(0, 0, 0, 0f);
            DeadlyGun2.SetActive(false);
            ShootSound2.SetActive(false);
        }
        if (ShootTime > 7f && ShootTime < 7.3f)
        {
            TargetColor3.color = new Color(0, 0, 0, 0f);
            DeadlyGun3.SetActive(false);
            ShootSound3.SetActive(false);
        }
        if (ShootTime > 7.5f)
        {
            LastPosition1 = Ball.transform.localPosition;
            LastPosition2 = Ball.transform.localPosition;
            LastPosition3 = Ball.transform.localPosition;
            ShootSound1.SetActive(false);
            ShootSound2.SetActive(false);
            ShootSound3.SetActive(false);
            DeadlyGun1.SetActive(false);
            DeadlyGun2.SetActive(false);
            DeadlyGun3.SetActive(false);
            TargetSound1.SetActive(false);
            TargetSound2.SetActive(false);
            TargetSound3.SetActive(false);
            ShootTime = 2f;
        }
    }

    private void OnEnable()
    {
        GunShot1.transform.localPosition = new Vector3(0, 0, 0);
        GunShot2.transform.localPosition = new Vector3(0, 0, 0);
        GunShot3.transform.localPosition = new Vector3(0, 0, 0);
        LastPosition1 = GunShot1.transform.localPosition;
        LastPosition2 = GunShot2.transform.localPosition;
        LastPosition3 = GunShot3.transform.localPosition;

        TargetSound1.SetActive(false);
        TargetSound2.SetActive(false);
        TargetSound3.SetActive(false);
        ShootSound1.SetActive(false);
        ShootSound2.SetActive(false);
        ShootSound3.SetActive(false);
        DeadlyGun1.SetActive(false);
        DeadlyGun2.SetActive(false);
        DeadlyGun3.SetActive(false);
        FirstPosition1 = GunShot1.transform.localPosition;
        FirstPosition2 = GunShot2.transform.localPosition;
        FirstPosition3 = GunShot3.transform.localPosition;
        
        TargetColor1.color = new Color(0, 1, 0, 0.75f);
        TargetColor2.color = new Color(0, 1, 0, 0.75f);
        TargetColor3.color = new Color(0, 1, 0, 0.75f);
        ShootTime = 0;

    }

    private void OnDisable()
    {
        GunShot1.transform.localPosition = new Vector3(0, 0, 0);
        GunShot2.transform.localPosition = new Vector3(0, 0, 0);
        GunShot3.transform.localPosition = new Vector3(0, 0, 0);
        LastPosition1 = GunShot1.transform.localPosition;
        LastPosition2 = GunShot2.transform.localPosition;
        LastPosition3 = GunShot3.transform.localPosition;
        ShootTime = 0;
    }
}
