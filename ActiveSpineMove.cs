using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSpineMoveRight : MonoBehaviour
{
    public GameObject Spine;

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
        if(ActiveTime == 0)
        {
            Spine.transform.localScale = new Vector3(0.5f, 0, 1);
        }
        if(Activebool == true)
        {
            ActiveTime += Time.deltaTime;
            if(ActiveTime > 0 && ActiveTime < 0.5f)
            {
                Spine.transform.localScale = new Vector3(0.5f, 2 * ActiveTime * 0.8f, 1);
            }
            if (ActiveTime >= 0.5f && ActiveTime < 2f)
            {
                Spine.transform.localScale = new Vector3(0.5f, 0.8f, 1);
            }
            if (ActiveTime >= 2 && ActiveTime < 2.5f)
            {
                Spine.transform.localScale = new Vector3(0.5f, 0.8f * 2 * (2.5f - ActiveTime), 1);
            }
            if (ActiveTime > 4f)
            {
                Spine.transform.localScale = new Vector3(0.5f, 0, 1);
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
