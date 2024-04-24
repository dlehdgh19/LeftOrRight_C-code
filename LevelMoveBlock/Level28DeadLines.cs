using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level28DeadLines : MonoBehaviour
{
    public GameObject XBlock1;
    public GameObject YBlock1;
    public SpriteRenderer XRend;
    public SpriteRenderer YRend;
    private int RandomInt;
    private bool Randombool = false;
    private int NextInt = 0;
    private float ActiveTime = 0;
    public GameObject RazorSound;
    public GameObject GateSound;
    public GameObject Gate;
    public GameObject SinXBlock;
    public GameObject SinYBlock;
    public SpriteRenderer SinXRend;
    public SpriteRenderer SinYRend;
    private float Deg;
    private float Rad;
    // Start is called before the first frame update
    void Start()
    {
        XBlock1.transform.position = new Vector3(0, 0, 0);
        YBlock1.transform.position = new Vector3(0, 0, 0);
        XBlock1.GetComponent<Collider2D>().enabled = false;
        YBlock1.GetComponent<Collider2D>().enabled = false;
        SinXBlock.GetComponent<Collider2D>().enabled = false;
        SinYBlock.GetComponent<Collider2D>().enabled = false;

        XRend.color = new Color(0, 0, 0, 0);
        YRend.color = new Color(0, 0, 0, 0);
        SinXRend.color = new Color(0, 0, 0, 0);
        SinYRend.color = new Color(0, 0, 0, 0);
        NextInt = 0;
        ActiveTime = 0;
        RazorSound.SetActive(false);
        GateSound.SetActive(false);
        Gate.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Randombool == false && NextInt < 5)
        {
            if(NextInt < 5)
            {
                RandomInt = Random.Range(1, 4);
                Randombool = true;
                
            }
        }
        if(Randombool == true)
        {
            ActiveTime += Time.deltaTime;
            
            switch(RandomInt)
            {
                case 1:
                    if(ActiveTime > 0 && ActiveTime < 5)
                    {
                        YBlock1.GetComponent<Collider2D>().enabled = false;
                        YRend.color = new Color(1, 0.5f, 0, 0.6f);
                        YBlock1.transform.localPosition = new Vector3((ActiveTime - 5f) * 3f, 0, 0);
                    }
                    if (ActiveTime > 5 && ActiveTime < 10)
                    {
                        RazorSound.SetActive(true);
                        YBlock1.GetComponent<Collider2D>().enabled = true;
                        YRend.color = new Color(1, 0, 0, 1);
                        YBlock1.transform.localPosition = new Vector3((ActiveTime - 5f) * 3f, 0, 0);
                    }
                    if(ActiveTime >= 10)
                    {
                        RazorSound.SetActive(false);
                        NextInt += 1;
                        Randombool = false;
                        ActiveTime = 0;
                    }
                    break;
                case 2:
                    if (ActiveTime > 0 && ActiveTime < 5)
                    {
                        YBlock1.GetComponent<Collider2D>().enabled = false;
                        YRend.color = new Color(1, 0.5f, 0, 0.6f);
                        YBlock1.transform.localPosition = new Vector3((-ActiveTime + 5f) * 3f, 0, 0);
                    }
                    if (ActiveTime > 5 && ActiveTime < 10)
                    {
                        RazorSound.SetActive(true);
                        YBlock1.GetComponent<Collider2D>().enabled = true;
                        YRend.color = new Color(1, 0, 0, 1);
                        YBlock1.transform.localPosition = new Vector3((-ActiveTime + 5f) * 3f, 0, 0);
                    }
                    if (ActiveTime >= 10)
                    {
                        RazorSound.SetActive(false);
                        NextInt += 1;
                        Randombool = false;
                        ActiveTime = 0;
                    }
                    break;
                case 3:
                    if (ActiveTime > 0 && ActiveTime < 6)
                    {
                        XBlock1.GetComponent<Collider2D>().enabled = false;
                        XRend.color = new Color(1, 0.5f, 0, 0.6f);
                        XBlock1.transform.localPosition = new Vector3(0, (-ActiveTime + 5f) * 2.5f, 0);
                    }
                    if (ActiveTime > 6 && ActiveTime < 10)
                    {
                        RazorSound.SetActive(true);
                        XBlock1.GetComponent<Collider2D>().enabled = true;
                        XRend.color = new Color(1, 0, 0, 1);
                        XBlock1.transform.localPosition = new Vector3(0, (-ActiveTime + 5f) * 2.5f, 0);
                    }
                    if (ActiveTime >= 10)
                    {
                        RazorSound.SetActive(false);
                        NextInt += 1;
                        Randombool = false;
                        ActiveTime = 0;
                    }
                    break;
                
            }
        }

        if(Randombool == false && NextInt == 5)
        {
            
            Rad = Mathf.Deg2Rad;
            Deg = 90 * Rad;
            ActiveTime += Time.deltaTime;
            if(ActiveTime > 0 && ActiveTime < 10)
            {
                SinYBlock.GetComponent<Collider2D>().enabled = true;
                SinYRend.color = new Color(1, 0, 0, 1);
                SinYBlock.transform.localPosition = new Vector3(8 * Mathf.Sin(ActiveTime * Deg), -(ActiveTime - 5) * 2, 0);
            }
            if (ActiveTime > 10 && ActiveTime < 20)
            {
                SinXBlock.GetComponent<Collider2D>().enabled = true;
                SinXRend.color = new Color(1, 0, 0, 1);
                SinXBlock.transform.localPosition = new Vector3((ActiveTime - 15) * 2, 6 * Mathf.Sin(ActiveTime * Deg), 0);
            }
            
            if (ActiveTime > 20 && ActiveTime < 30)
            {
                SinYBlock.transform.localPosition = new Vector3(8 * Mathf.Sin(ActiveTime * Deg), -(ActiveTime - 25) * 2, 0);
                SinXBlock.transform.localPosition = new Vector3((ActiveTime - 25) * 2, 6 * Mathf.Sin(ActiveTime * Deg), 0);
            }
            if (ActiveTime >= 30)
            {
                GateSound.SetActive(true);
                Gate.SetActive(false);
            }
        }
    }

    private void OnEnable()
    {
        XBlock1.transform.position = new Vector3(0, 0, 0);
        YBlock1.transform.position = new Vector3(0, 0, 0);
        XBlock1.GetComponent<Collider2D>().enabled = false;
        YBlock1.GetComponent<Collider2D>().enabled = false;
        SinXBlock.GetComponent<Collider2D>().enabled = false;
        SinYBlock.GetComponent<Collider2D>().enabled = false;
        SinXBlock.transform.position = new Vector3(0, 100, 0);
        SinYBlock.transform.position = new Vector3(0, 100, 0);
        XRend.color = new Color(0, 0, 0, 0);
        YRend.color = new Color(0, 0, 0, 0);
        SinXRend.color = new Color(0, 0, 0, 0);
        SinYRend.color = new Color(0, 0, 0, 0);
        NextInt = 0;
        ActiveTime = 0;
        RazorSound.SetActive(false);
        GateSound.SetActive(false);
        Gate.SetActive(true);
        
    }

    private void OnDisable()
    {
        XBlock1.transform.position = new Vector3(0, 0, 0);
        YBlock1.transform.position = new Vector3(0, 0, 0);
        XBlock1.GetComponent<Collider2D>().enabled = false;
        YBlock1.GetComponent<Collider2D>().enabled = false;
        SinXBlock.GetComponent<Collider2D>().enabled = false;
        SinYBlock.GetComponent<Collider2D>().enabled = false;
        SinXBlock.transform.position = new Vector3(0, 100, 0);
        SinYBlock.transform.position = new Vector3(0, 100, 0);
        XRend.color = new Color(0, 0, 0, 0);
        YRend.color = new Color(0, 0, 0, 0);
        SinXRend.color = new Color(0, 0, 0, 0);
        SinYRend.color = new Color(0, 0, 0, 0);
        NextInt = 0;
        ActiveTime = 0;
        RazorSound.SetActive(false);
        GateSound.SetActive(false);
        Gate.SetActive(true);
        
    }


}
