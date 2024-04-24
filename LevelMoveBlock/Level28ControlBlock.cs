using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level28ControlBlock : MonoBehaviour
{
    public GameObject Block1;
    public GameObject Block2;
    public SpriteRenderer Rend1;
    public SpriteRenderer Rend2;
    private float MovingTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovingTime += Time.deltaTime;
        if (MovingTime > 4 && MovingTime < 8)
        {
            Block1.GetComponent<Collider2D>().enabled = false;
            Rend1.color = new Color(1, 0.5f, 0, 0.6f);
            Block1.SetActive(true);
        }
        if (MovingTime > 8 && MovingTime < 12)
        {
            Block1.GetComponent<Collider2D>().enabled = true;
            Rend1.color = new Color(1, 0f, 0, 1f);
        }
        if (MovingTime > 12 && MovingTime < 18)
        {
            Block1.GetComponent<Collider2D>().enabled = false;
            Rend1.color = new Color(0, 0f, 0, 0f);
            Block1.SetActive(false);
        }
        if (MovingTime > 18 && MovingTime < 22)
        {
            Block2.GetComponent<Collider2D>().enabled = false;
            Rend2.color = new Color(1, 0.5f, 0, 0.6f);
            Block2.SetActive(true);
        }
        if (MovingTime > 22 && MovingTime < 26)
        {
            Block2.GetComponent<Collider2D>().enabled = true;
            Rend2.color = new Color(1, 0f, 0, 1f);
        }
        if (MovingTime > 26 && MovingTime < 28)
        {
            Block2.GetComponent<Collider2D>().enabled = false;
            Rend2.color = new Color(0, 0f, 0, 0f);
            Block2.SetActive(false);
        }
        if (MovingTime > 28)
        {
            MovingTime = 0;
        }
    }

    private void OnEnable()
    {
        MovingTime = 0;
        Block1.SetActive(false);
        Block2.SetActive(false);
        Rend1.color = new Color(0, 0, 0, 0);
        Rend2.color = new Color(0, 0, 0, 0);
        Block1.GetComponent<Collider2D>().enabled = false;
        Block2.GetComponent<Collider2D>().enabled = false;

    }

    private void OnDisable()
    {
        MovingTime = 0;
        Block1.SetActive(false);
        Block2.SetActive(false);
        Rend1.color = new Color(0, 0, 0, 0);
        Rend2.color = new Color(0, 0, 0, 0);
        Block1.GetComponent<Collider2D>().enabled = false;
        Block2.GetComponent<Collider2D>().enabled = false;
    }
}
