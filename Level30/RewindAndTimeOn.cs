using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindAndTimeOn : MonoBehaviour
{
    public SpriteRenderer Rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            NeedleControl.Rewindbool = true;
            Rend.color = new Color(1, 1, 1, 0);
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnEnable()
    {
        Rend.color = new Color(1, 1, 1, 1);
        this.GetComponent<BoxCollider2D>().enabled = true;
    }

    private void OnDisable()
    {
        Rend.color = new Color(1, 1, 1, 1);
        this.GetComponent<BoxCollider2D>().enabled = true;
    }
}
