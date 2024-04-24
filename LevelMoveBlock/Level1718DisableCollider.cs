using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1718DisableCollider : MonoBehaviour
{
    private float ColorTime;
    public float TurnTime;
    public SpriteRenderer myMat;
    // Start is called before the first frame update
    void Start()
    {
        ColorTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ColorTime += Time.deltaTime;
        if(ColorTime > 0 && ColorTime < TurnTime)
        {
            myMat.color = new Color(1, 0, 0, 0.9f);
            GetComponent<BoxCollider2D>().enabled = true;
        }
        if (ColorTime >= TurnTime && ColorTime < 2 * TurnTime)
        {
            myMat.color = new Color(0, 1, 0, 0.65f);
            GetComponent<BoxCollider2D>().enabled = false;
        }
        if (ColorTime >= 2 * TurnTime)
        {
            ColorTime = 0;
        }
    }
}
