using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level25SpawnRedBlockAndOpenGate : MonoBehaviour
{
    public GameObject Gate;
    public GameObject[] RedCapsule;
    public SpriteRenderer[] RedCapsuleColor;
    private float RandomTime;
    private int RandomInt;
    private bool Randombool = false;
    private float SpawningTime = 0;
    public GameObject GateSound;
    private float DisAffectCollidertime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DisAffectTime();

        if (Randombool == false)
        {
            RandomTime += Time.deltaTime;
        }
        if (RandomTime > 4f && Randombool == false)
        {
            RandomInt = Random.Range(1, 9);
            Randombool = true;
            RandomTime = 4f;
        }
        if (Randombool == true && Level25LeftRightRedBlockMove.FirstSpawnbool == true)
        {
            SpawningTime += Time.deltaTime;
            if (SpawningTime > 0 && SpawningTime < 2)
            {
                switch (RandomInt)
                {
                    case 1:
                        RedCapsule[0].transform.localPosition = new Vector3(-0.8f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 2:
                        RedCapsule[0].transform.localPosition = new Vector3(-0.8f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 3:
                        RedCapsule[0].transform.localPosition = new Vector3(-0.8f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 4:
                        RedCapsule[0].transform.localPosition = new Vector3(-0.8f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 5:
                        RedCapsule[1].transform.localPosition = new Vector3(0.8f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 6:
                        RedCapsule[1].transform.localPosition = new Vector3(0.8f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 7:
                        RedCapsule[1].transform.localPosition = new Vector3(0.8f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 8:
                        RedCapsule[1].transform.localPosition = new Vector3(0.8f, 5 - (6 * SpawningTime), 0);
                        break;
                    default:
                    break;
                }

            }
            if(SpawningTime > 2)
            {
                SpawningTime = 0;
                Randombool = false;
            }
        }

        if (Randombool == true && Level25LeftRightRedBlockMove.SeceondSpawnbool == true)
        {
            SpawningTime += Time.deltaTime;
            if (SpawningTime > 0 && SpawningTime < 2)
            {
                switch (RandomInt)
                {
                    case 1:
                        RedCapsule[2].transform.localPosition = new Vector3(-1.7f, 5 - (6 * SpawningTime), 0);
                        RedCapsule[3].transform.localPosition = new Vector3(0f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 2:
                        RedCapsule[2].transform.localPosition = new Vector3(-1.7f, 5 - (6 * SpawningTime), 0);
                        RedCapsule[3].transform.localPosition = new Vector3(0f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 3:
                        RedCapsule[2].transform.localPosition = new Vector3(-1.7f, 5 - (6 * SpawningTime), 0);
                        RedCapsule[4].transform.localPosition = new Vector3(1.7f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 4:
                        RedCapsule[2].transform.localPosition = new Vector3(-1.7f, 5 - (6 * SpawningTime), 0);
                        RedCapsule[4].transform.localPosition = new Vector3(1.7f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 5:
                        RedCapsule[3].transform.localPosition = new Vector3(0f, 5 - (6 * SpawningTime), 0);
                        RedCapsule[4].transform.localPosition = new Vector3(1.7f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 6:
                        RedCapsule[3].transform.localPosition = new Vector3(0f, 5 - (6 * SpawningTime), 0);
                        RedCapsule[4].transform.localPosition = new Vector3(1.7f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 7:
                        RedCapsule[2].transform.localPosition = new Vector3(-1.7f, 5 - (6 * SpawningTime), 0);
                        RedCapsule[3].transform.localPosition = new Vector3(0f, 5 - (6 * SpawningTime), 0);
                        break;
                    case 8:
                        RedCapsule[3].transform.localPosition = new Vector3(0f, 5 - (6 * SpawningTime), 0);
                        RedCapsule[4].transform.localPosition = new Vector3(1.7f, 5 - (6 * SpawningTime), 0);
                        break;
                    default:
                        break;
                }
            }
            if (SpawningTime > 2)
            {
                SpawningTime = 0;
                Randombool = false;
            }
        }
    }



    private void OnEnable()
    {
        GateSound.SetActive(false);
        Gate.SetActive(true);
        Randombool = false;
        RandomTime = 0;
        SpawningTime = 0;
        DisAffectCollidertime = 0;
        for (int i = 0; i < 5; i++)
        {
            RedCapsule[0].transform.localPosition = new Vector3(-0.8f, 5, 0);
            RedCapsule[1].transform.localPosition = new Vector3(0.8f, 5, 0);
            RedCapsule[2].transform.localPosition = new Vector3(-1.7f, 5, 0);
            RedCapsule[3].transform.localPosition = new Vector3(0f, 5, 0);
            RedCapsule[4].transform.localPosition = new Vector3(-1.7f, 5, 0);
            RedCapsule[i].GetComponent<CapsuleCollider2D>().enabled = false;
            RedCapsuleColor[i].color = new Color(0, 0, 0, 0);
        }
    }

    private void OnDisable()
    {
        GateSound.SetActive(false);
        SpawningTime = 0;
        Randombool = false;
        RandomTime = 0;
        DisAffectCollidertime = 0;
        for (int i = 0; i < 5; i++)
        {
            RedCapsule[0].transform.localPosition = new Vector3(-0.8f, 5, 0);
            RedCapsule[1].transform.localPosition = new Vector3(0.8f, 5, 0);
            RedCapsule[2].transform.localPosition = new Vector3(-1.7f, 5, 0);
            RedCapsule[3].transform.localPosition = new Vector3(0f, 5, 0);
            RedCapsule[4].transform.localPosition = new Vector3(-1.7f, 5, 0);
            RedCapsule[i].GetComponent<CapsuleCollider2D>().enabled = false;
            RedCapsuleColor[i].color = new Color(0, 0, 0, 0);
        }
    }

    private void DisAffectTime()
    {
        DisAffectCollidertime += Time.deltaTime;
        if(DisAffectCollidertime > 0 && DisAffectCollidertime < 29.99f)
        {
            for (int i = 0; i < 2; i++)
            {
                RedCapsule[i].GetComponent<CapsuleCollider2D>().enabled = true;
                RedCapsuleColor[i].color = new Color(1, 0, 0, 1);
            }
        }
        if (DisAffectCollidertime > 30 && DisAffectCollidertime < 59.99f)
        {
            for (int i = 0; i < 2; i++)
            {
                RedCapsule[i].GetComponent<CapsuleCollider2D>().enabled = false;
                RedCapsuleColor[i].color = new Color(0, 0, 0, 0);
            }
            for (int i = 2; i < 5; i++)
            {
                RedCapsule[i].GetComponent<CapsuleCollider2D>().enabled = true;
                RedCapsuleColor[i].color = new Color(1, 0, 0, 1);
            }
        }
        if (DisAffectCollidertime > 60f)
        {
            for (int i = 2; i < 5; i++)
            {
                RedCapsule[i].GetComponent<CapsuleCollider2D>().enabled = false;
                RedCapsuleColor[i].color = new Color(0, 0, 0, 0);
                Gate.SetActive(false);
                GateSound.SetActive(true);
            }
        
        }
    }
}
