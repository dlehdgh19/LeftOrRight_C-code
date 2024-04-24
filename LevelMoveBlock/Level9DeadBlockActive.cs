using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level9DeadBlockActive : MonoBehaviour
{
    public GameObject DeadBlock;

    private float ActiveTime;
    private bool Activebool;
    // Start is called before the first frame update
    void Start()
    {
        ActiveTime = 0;
        Activebool = false;
    }

    private void OnEnable()
    {
        ActiveTime = 0;
        Activebool = false;
    }

    private void OnDisable()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ActiveTime == 0)
        {
            DeadBlock.transform.localScale = new Vector3(1, 0, 0);
        }
        if (Activebool == true)
        {
            ActiveTime += Time.deltaTime;
            if (ActiveTime > 0 && ActiveTime < 0.5f)
            {
                DeadBlock.transform.localScale = new Vector3(2 * ActiveTime * 1f, 0.45f, 1);
            }
            if (ActiveTime >= 0.5f && ActiveTime < 2f)
            {
                DeadBlock.transform.localScale = new Vector3(1, 0.45f, 1);
            }
            if (ActiveTime >= 2 && ActiveTime < 2.5f)
            {
                DeadBlock.transform.localScale = new Vector3(1f * 2 * (2.5f - ActiveTime), 0.45f, 1);
            }
            if (ActiveTime > 4f)
            {
                DeadBlock.transform.localScale = new Vector3(0, 0, 1);
                Activebool = false;
                ActiveTime = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball" && Activebool == false)
        {
            Activebool = true;
        }
    }
}
