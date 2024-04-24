using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level29Collider : MonoBehaviour
{
    public GameObject[] RedBlock;
    public SpriteRenderer[] Rends;
    private float ActiveTime = 0;
    public GameObject LazorAudio;
    public GameObject LastBlock;
    public SpriteRenderer LastRend;
    public GameObject Gate;
    public GameObject GateAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Level29RedMapMove.NextStepbool == true)
        {
            ActiveTime += Time.deltaTime;
            //---------------------------------------------------------------------------------------
            if(ActiveTime > 0 && ActiveTime < 1.5f)
            {
                for (int i = 0; i < 2; i++)
                {
                    RedBlock[i].SetActive(true);
                    RedBlock[i].GetComponent<Collider2D>().enabled = false;
                    Rends[i].color = new Color(1, 0.5f, 0, 0.6f);
                }
            }
            if (ActiveTime > 1.5f && ActiveTime < 3f)
            {
                for (int i = 0; i < 2; i++)
                {
                    LazorAudio.SetActive(true);
                    RedBlock[i].SetActive(true);
                    RedBlock[i].GetComponent<Collider2D>().enabled = true;
                    Rends[i].color = new Color(1, 0, 0, 1f);
                }
            }
            if (ActiveTime > 3f && ActiveTime < 4f)
            {
                for (int i = 0; i < 2; i++)
                {
                    LazorAudio.SetActive(false);
                    RedBlock[i].SetActive(false);
                    RedBlock[i].GetComponent<Collider2D>().enabled = false;
                    Rends[i].color = new Color(0, 0, 0, 0f);
                }
            }
            // ---------------------------------------------------------------------------------------
            if (ActiveTime > 4 && ActiveTime < 5.5f)
            {
                for (int i = 2; i < 4; i++)
                {
                    RedBlock[i].SetActive(true);
                    RedBlock[i].GetComponent<Collider2D>().enabled = false;
                    Rends[i].color = new Color(1, 0.5f, 0, 0.6f);
                }
            }
            if (ActiveTime > 5.5f && ActiveTime < 7f)
            {
                for (int i = 2; i < 4; i++)
                {
                    LazorAudio.SetActive(true);
                    RedBlock[i].SetActive(true);
                    RedBlock[i].GetComponent<Collider2D>().enabled = true;
                    Rends[i].color = new Color(1, 0, 0, 1f);
                }
            }
            if (ActiveTime > 7f && ActiveTime < 8f)
            {
                for (int i = 2; i < 4; i++)
                {
                    LazorAudio.SetActive(false);
                    RedBlock[i].SetActive(false);
                    RedBlock[i].GetComponent<Collider2D>().enabled = false;
                    Rends[i].color = new Color(0, 0, 0, 0f);
                }
            }
            // ---------------------------------------------------------------------------------------
            if (ActiveTime > 8 && ActiveTime < 9.5f)
            {
                for (int i = 4; i < 6; i++)
                {
                    RedBlock[i].SetActive(true);
                    RedBlock[i].GetComponent<Collider2D>().enabled = false;
                    Rends[i].color = new Color(1, 0.5f, 0, 0.6f);
                }
            }
            if (ActiveTime > 9.5f && ActiveTime < 11f)
            {
                for (int i = 4; i < 6; i++)
                {
                    LazorAudio.SetActive(true);
                    RedBlock[i].SetActive(true);
                    RedBlock[i].GetComponent<Collider2D>().enabled = true;
                    Rends[i].color = new Color(1, 0, 0, 1f);
                }
            }
            if (ActiveTime > 11f && ActiveTime < 13f)
            {
                for (int i = 4; i < 6; i++)
                {
                    LazorAudio.SetActive(false);
                    RedBlock[i].SetActive(false);
                    RedBlock[i].GetComponent<Collider2D>().enabled = false;
                    Rends[i].color = new Color(0, 0, 0, 0f);
                }
            }
            // ---------------------------------------------------------------------------------------
            if(ActiveTime > 13f && ActiveTime < 15f)
            {
                LastBlock.GetComponent<Collider2D>().enabled = false;
                LastRend.color = new Color(1, 0.5f, 0, 0.6f);
            }
            if (ActiveTime > 15f && ActiveTime < 20f)
            {
                LazorAudio.SetActive(true);
                LastBlock.GetComponent<Collider2D>().enabled = true;
                LastRend.color = new Color(1, 0f, 0, 1f);
                LastBlock.transform.Rotate(new Vector3(0, 0, 60 * Time.deltaTime));
            }
            if (ActiveTime > 21f && ActiveTime < 26f)
            {
                LazorAudio.SetActive(true);
                LastBlock.GetComponent<Collider2D>().enabled = true;
                LastRend.color = new Color(1, 0f, 0, 1f);
                LastBlock.transform.Rotate(new Vector3(0, 0, -60 * Time.deltaTime));
            }
            if (ActiveTime >= 26f)
            {
                LazorAudio.SetActive(false);
                LastBlock.GetComponent<Collider2D>().enabled = false;
                LastRend.color = new Color(0, 0f, 0, 0f);
                Gate.SetActive(false);
                GateAudio.SetActive(true);
            }
        }
    }

    private void OnEnable()
    {
        for(int i = 0; i < 6; i++)
        {
            RedBlock[i].SetActive(false);
            RedBlock[i].GetComponent<Collider2D>().enabled = false;
            Rends[i].color = new Color(0, 0, 0, 0);
        }
        Level29RedMapMove.NextStepbool = false;
        ActiveTime = 0;
        LastBlock.transform.rotation = Quaternion.Euler(0, 0, 0);
        LastBlock.GetComponent<Collider2D>().enabled = false;
        LastRend.color = new Color(0, 0, 0, 0);
        Gate.SetActive(true);
        GateAudio.SetActive(false);
        LazorAudio.SetActive(false);
    }

    private void OnDisable()
    {
        for (int i = 0; i < 6; i++)
        {
            RedBlock[i].SetActive(false);
            RedBlock[i].GetComponent<Collider2D>().enabled = false;
            Rends[i].color = new Color(0, 0, 0, 0);
        }
        Level29RedMapMove.NextStepbool = false;
        ActiveTime = 0;
        LastBlock.transform.rotation = Quaternion.Euler(0, 0, 0);
        LastBlock.GetComponent<Collider2D>().enabled = false;
        LastRend.color = new Color(0, 0, 0, 0);
        Gate.SetActive(false);
        GateAudio.SetActive(false);
        LazorAudio.SetActive(false);
    }
}
