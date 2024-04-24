using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level27SpiningBlock : MonoBehaviour
{
    public GameObject[] SpiningBlock;
    public SpriteRenderer[] BlockColor;
    public float SpinSpeed;
    private bool Randombool = false;
    private bool ActiveColliderbool = false;
    private float ActiveTime1;
    private float ActiveTime2;
    private float time1;
    private float time2;
    public GameObject LazorSound;
    public GameObject GateSound;
    public GameObject Gate;
    private int EndInt = 0;
    // Start is called before the first frame update
    void Start()
    {
        LazorSound.SetActive(false);
        GateSound.SetActive(false);
        Gate.SetActive(true);
        EndInt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(EndInt < 5)
        {
            ActiveTime1 += Time.deltaTime;
        }

        SpiningBlock[0].transform.Rotate(new Vector3(0, 0, SpinSpeed * Time.deltaTime));
        SpiningBlock[1].transform.Rotate(new Vector3(0, 0, SpinSpeed * Time.deltaTime));
        SpiningBlock[2].transform.Rotate(new Vector3(0, 0, -SpinSpeed * Time.deltaTime));
        SpiningBlock[3].transform.Rotate(new Vector3(0, 0, -SpinSpeed * Time.deltaTime));

        if(ActiveTime1 >= 3 && Randombool == false)
        {
            time1 = Random.Range(1.0f, 2f);
            time2 = Random.Range(1.0f, 2f);
            Randombool = true;
        }

        if(Randombool == true)
        {
            ActiveTime2 += Time.deltaTime;
            if(ActiveTime2 > 0 && ActiveTime2 < time1)
            {
                BlockColor[0].color = new Color(0, 1, 0, 0.8f);
                BlockColor[1].color = new Color(0, 1, 0, 0.8f);
                BlockColor[2].color = new Color(0, 1, 0, 0.8f);
                BlockColor[3].color = new Color(0, 1, 0, 0.8f);
            }
            if (ActiveTime2 > time1 && ActiveTime2 < time1 + 1f)
            {
                BlockColor[0].color = new Color(1, 0.5f, 0, 0.8f);
                BlockColor[1].color = new Color(1, 0.5f, 0, 0.8f);
                BlockColor[2].color = new Color(0, 1, 0, 0.8f);
                BlockColor[3].color = new Color(0, 1, 0, 0.8f);
            }
            if (ActiveTime2 > time1 + 1f && ActiveTime2 < time1 + 3f)
            {
                BlockColor[0].color = new Color(1, 0, 0, 1f);
                BlockColor[1].color = new Color(1, 0, 0, 1f);
                BlockColor[2].color = new Color(0, 1, 0, 0.8f);
                BlockColor[3].color = new Color(0, 1, 0, 0.8f);
                SpiningBlock[0].GetComponent<BoxCollider2D>().enabled = true;
                SpiningBlock[1].GetComponent<BoxCollider2D>().enabled = true;
                LazorSound.SetActive(true);
            }
            if (ActiveTime2 > time1 + 3f && ActiveTime2 < time1 + 3f + time2)
            {
                BlockColor[0].color = new Color(0, 1, 0, 0.8f);
                BlockColor[1].color = new Color(0, 1, 0, 0.8f);
                BlockColor[2].color = new Color(0, 1, 0, 0.8f);
                BlockColor[3].color = new Color(0, 1, 0, 0.8f);
                SpiningBlock[0].GetComponent<BoxCollider2D>().enabled = false;
                SpiningBlock[1].GetComponent<BoxCollider2D>().enabled = false;
                LazorSound.SetActive(false);
            }
            if (ActiveTime2 > time1 + 3f + time2 && ActiveTime2 < time1 + 4f + time2)
            {
                BlockColor[0].color = new Color(0, 1, 0, 0.8f);
                BlockColor[1].color = new Color(0, 1, 0, 0.8f);
                BlockColor[2].color = new Color(1, 0.5f, 0, 0.8f);
                BlockColor[3].color = new Color(1, 0.5f, 0, 0.8f);
            }
            if (ActiveTime2 > time1 + 4f + time2 && ActiveTime2 < time1 + 6f + time2)
            {
                BlockColor[0].color = new Color(0, 1, 0, 0.8f);
                BlockColor[1].color = new Color(0, 1, 0, 0.8f);
                BlockColor[2].color = new Color(1, 0, 0, 1f);
                BlockColor[3].color = new Color(1, 0, 0, 1f);
                SpiningBlock[2].GetComponent<BoxCollider2D>().enabled = true;
                SpiningBlock[3].GetComponent<BoxCollider2D>().enabled = true;
                LazorSound.SetActive(true);
            }
            if (ActiveTime2 > time1 + 6f + time2 && ActiveTime2 < time1 + 7f + time2)
            {
                BlockColor[0].color = new Color(0, 1, 0, 0.8f);
                BlockColor[1].color = new Color(0, 1, 0, 0.8f);
                BlockColor[2].color = new Color(0, 1, 0, 0.8f);
                BlockColor[3].color = new Color(0, 1, 0, 0.8f);
                SpiningBlock[2].GetComponent<BoxCollider2D>().enabled = false;
                SpiningBlock[3].GetComponent<BoxCollider2D>().enabled = false;
                LazorSound.SetActive(false);
            }
            if (ActiveTime2 > time1 + 7f + time2)
            {
                ActiveTime1 = 3;
                ActiveTime2 = 0;
                Randombool = false;
                EndInt += 1;
            }
        }

        if(EndInt == 5)
        {
            BlockColor[0].color = new Color(0, 1, 0, 0.8f);
            BlockColor[1].color = new Color(0, 1, 0, 0.8f);
            BlockColor[2].color = new Color(0, 1, 0, 0.8f);
            BlockColor[3].color = new Color(0, 1, 0, 0.8f);
            SpiningBlock[0].GetComponent<BoxCollider2D>().enabled = false;
            SpiningBlock[1].GetComponent<BoxCollider2D>().enabled = false;
            SpiningBlock[2].GetComponent<BoxCollider2D>().enabled = false;
            SpiningBlock[3].GetComponent<BoxCollider2D>().enabled = false;
            ActiveTime1 = 0;
            ActiveTime2 = 0;
            Randombool = false;

            LazorSound.SetActive(false);
            GateSound.SetActive(true);
            Gate.SetActive(false);
        }
    }

    private void OnEnable()
    {
        SpiningBlock[0].transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        SpiningBlock[1].transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
        SpiningBlock[2].transform.rotation = Quaternion.Euler(new Vector3(0, 0, -45));
        SpiningBlock[3].transform.rotation = Quaternion.Euler(new Vector3(0, 0, 45));

        for(int i = 0; i < 4; i++)
        {
            SpiningBlock[i].GetComponent<BoxCollider2D>().enabled = false;
            BlockColor[i].color = new Color(0, 1, 0, 0.8f);
        }
        GateSound.SetActive(false);
        LazorSound.SetActive(false);
        Gate.SetActive(true);
        ActiveTime1 = 0;
        ActiveTime2 = 0;
        EndInt = 0;
        Randombool = false;
    }

    private void OnDisable()
    {
        LazorSound.SetActive(false);
        GateSound.SetActive(false);
        Gate.SetActive(true);
        ActiveTime1 = 0;
        ActiveTime2 = 0;
        EndInt = 0;
    }
}
