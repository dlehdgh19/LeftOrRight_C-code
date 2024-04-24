using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level16SafeBlockGone : MonoBehaviour
{
    private float TurnColorTime;
    public GameObject[] SafeBlocks;
    public SpriteRenderer[] myMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TurnColorTime += Time.deltaTime;
        if(TurnColorTime > 0 && TurnColorTime < 1)
        {
            myMat[0].color = new Color(1, 1, 1, TurnColorTime);
            myMat[1].color = new Color(1, 1, 1, 0f);
            myMat[2].color = new Color(1, 1, 1, 0f);
            myMat[3].color = new Color(1, 1, 1, TurnColorTime);
            myMat[4].color = new Color(1, 1, 1, 0f);
            myMat[5].color = new Color(1, 1, 1, 0f);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = false;
        }
        if (TurnColorTime > 1 && TurnColorTime < 2)
        {
            myMat[0].color = new Color(1, 1, 1, 1);
            myMat[1].color = new Color(1, 1, 1, 0f);
            myMat[2].color = new Color(1, 1, 1, 0f);
            myMat[3].color = new Color(1, 1, 1, 1);
            myMat[4].color = new Color(1, 1, 1, 0f);
            myMat[5].color = new Color(1, 1, 1, 0f);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = false;
        }
        if (TurnColorTime > 2 && TurnColorTime < 3)
        {
            myMat[0].color = new Color(1, 1, 1, 1f);
            myMat[1].color = new Color(1, 1, 1, TurnColorTime - 2);
            myMat[2].color = new Color(1, 1, 1, 0f);
            myMat[3].color = new Color(1, 1, 1, 1f);
            myMat[4].color = new Color(1, 1, 1, TurnColorTime - 2);
            myMat[5].color = new Color(1, 1, 1, 0f);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = false;
        }
        if (TurnColorTime > 3 && TurnColorTime < 4)
        {
            myMat[0].color = new Color(1, 1, 1, 1f);
            myMat[1].color = new Color(1, 1, 1, 1f);
            myMat[2].color = new Color(1, 1, 1, 0f);
            myMat[3].color = new Color(1, 1, 1, 1f);
            myMat[4].color = new Color(1, 1, 1, 1f);
            myMat[5].color = new Color(1, 1, 1, 0f);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = false;
        }
        if (TurnColorTime > 4 && TurnColorTime < 5)
        {
            myMat[0].color = new Color(1, 1, 1, 5 - TurnColorTime);
            myMat[1].color = new Color(1, 1, 1, 1f);
            myMat[2].color = new Color(1, 1, 1, 0f);
            myMat[3].color = new Color(1, 1, 1, 5 - TurnColorTime);
            myMat[4].color = new Color(1, 1, 1, 1f);
            myMat[5].color = new Color(1, 1, 1, 0f);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = false;
        }
        if (TurnColorTime > 5 && TurnColorTime < 6)
        {
            myMat[0].color = new Color(1, 1, 1, 0);
            myMat[1].color = new Color(1, 1, 1, 1f);
            myMat[2].color = new Color(1, 1, 1, TurnColorTime - 5);
            myMat[3].color = new Color(1, 1, 1, 0);
            myMat[4].color = new Color(1, 1, 1, 1f);
            myMat[5].color = new Color(1, 1, 1, TurnColorTime - 5);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = true;
        }
        if (TurnColorTime > 6 && TurnColorTime < 7)
        {
            myMat[0].color = new Color(1, 1, 1, 0);
            myMat[1].color = new Color(1, 1, 1, 1);
            myMat[2].color = new Color(1, 1, 1, 1);
            myMat[3].color = new Color(1, 1, 1, 0);
            myMat[4].color = new Color(1, 1, 1, 1);
            myMat[5].color = new Color(1, 1, 1, 1);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = true;
        }
        if (TurnColorTime > 7 && TurnColorTime < 8)
        {
            myMat[0].color = new Color(1, 1, 1, 0);
            myMat[1].color = new Color(1, 1, 1, 8 - TurnColorTime);
            myMat[2].color = new Color(1, 1, 1, 1);
            myMat[3].color = new Color(1, 1, 1, 0);
            myMat[4].color = new Color(1, 1, 1, 8 - TurnColorTime);
            myMat[5].color = new Color(1, 1, 1, 1);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = true;
        }
        if (TurnColorTime > 8 && TurnColorTime < 9)
        {
            myMat[0].color = new Color(1, 1, 1, 0);
            myMat[1].color = new Color(1, 1, 1, 0);
            myMat[2].color = new Color(1, 1, 1, 1);
            myMat[3].color = new Color(1, 1, 1, 0);
            myMat[4].color = new Color(1, 1, 1, 0);
            myMat[5].color = new Color(1, 1, 1, 1);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = true;
        }
        if (TurnColorTime > 9 && TurnColorTime < 10)
        {
            myMat[0].color = new Color(1, 1, 1, 0);
            myMat[1].color = new Color(1, 1, 1, 0);
            myMat[2].color = new Color(1, 1, 1, 10 - TurnColorTime);
            myMat[3].color = new Color(1, 1, 1, 0);
            myMat[4].color = new Color(1, 1, 1, 0);
            myMat[5].color = new Color(1, 1, 1, 10 - TurnColorTime);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = true;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = true;
        }
        if (TurnColorTime > 10 && TurnColorTime < 11)
        {
            myMat[0].color = new Color(1, 1, 1, 0);
            myMat[1].color = new Color(1, 1, 1, 0);
            myMat[2].color = new Color(1, 1, 1, 0);
            myMat[3].color = new Color(1, 1, 1, 0);
            myMat[4].color = new Color(1, 1, 1, 0);
            myMat[5].color = new Color(1, 1, 1, 0);
            SafeBlocks[0].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[1].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[2].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[3].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[4].GetComponent<BoxCollider2D>().enabled = false;
            SafeBlocks[5].GetComponent<BoxCollider2D>().enabled = false;
        }
        if (TurnColorTime > 11)
        {
            TurnColorTime = 0;
        }
    }
}
