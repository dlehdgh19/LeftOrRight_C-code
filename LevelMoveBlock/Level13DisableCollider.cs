using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level13DisableCollider : MonoBehaviour
{
    private float TurnColorTime;
    public float TurnTermTime;
    public GameObject[] StrongForceZones;
    public SpriteRenderer[] myMat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TurnColorTime += TurnTermTime * Time.deltaTime;
        if(TurnColorTime > 0 && TurnColorTime < 2.5f)
        {
            myMat[0].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[1].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[2].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[3].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[4].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[5].color = new Color(0.85f, 0, 1, 0.45f);
            StrongForceZones[0].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[1].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[2].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[3].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[4].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[5].GetComponent<BoxCollider2D>().enabled = true;
        }
        if (TurnColorTime > 2.5f && TurnColorTime < 5f)
        {
            myMat[0].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[1].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[2].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[3].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[4].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[5].color = new Color(0.85f, 0, 1, 0.45f);
            StrongForceZones[0].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[1].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[2].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[3].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[4].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[5].GetComponent<BoxCollider2D>().enabled = true;
        }
        if (TurnColorTime > 5f && TurnColorTime < 7.5f)
        {
            myMat[0].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[1].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[2].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[3].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[4].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[5].color = new Color(0.85f, 0, 1, 0.45f);
            StrongForceZones[0].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[1].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[2].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[3].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[4].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[5].GetComponent<BoxCollider2D>().enabled = true;
        }
        if (TurnColorTime > 7.5f && TurnColorTime < 10f)
        {
            myMat[0].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[1].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[2].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[3].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[4].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[5].color = new Color(0.2f, 1, 0, 0.45f);
            StrongForceZones[0].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[1].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[2].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[3].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[4].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[5].GetComponent<BoxCollider2D>().enabled = false;
        }
        if (TurnColorTime > 10f && TurnColorTime < 12.5f)
        {
            myMat[0].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[1].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[2].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[3].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[4].color = new Color(0.2f, 1, 0, 0.45f);
            myMat[5].color = new Color(0.2f, 1, 0, 0.45f);
            StrongForceZones[0].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[1].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[2].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[3].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[4].GetComponent<BoxCollider2D>().enabled = false;
            StrongForceZones[5].GetComponent<BoxCollider2D>().enabled = false;
        }
        if (TurnColorTime > 12.5f && TurnColorTime < 15f)
        {
            myMat[0].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[1].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[2].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[3].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[4].color = new Color(0.85f, 0, 1, 0.45f);
            myMat[5].color = new Color(0.85f, 0, 1, 0.45f);
            StrongForceZones[0].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[1].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[2].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[3].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[4].GetComponent<BoxCollider2D>().enabled = true;
            StrongForceZones[5].GetComponent<BoxCollider2D>().enabled = true;
        }
        if (TurnColorTime >= 11.6f)
        {
            TurnColorTime = 0;
        }
    }
}
