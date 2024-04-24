using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStart : MonoBehaviour
{
    public SpriteRenderer Rend;
    public GameObject TimeStartSound;
    // Start is called before the first frame update
    void Start()
    {
        TimeStartSound.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            TimeStartSound.SetActive(true);
            NeedleControl.TimeStartbool = true;
            Rend.color = new Color(1, 1, 1, 0);
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnEnable()
    {
        Rend.color = new Color(1, 1, 1, 1);
        TimeStartSound.SetActive(false);
        this.GetComponent<BoxCollider2D>().enabled = true;
    }

    private void OnDisable()
    {
        Rend.color = new Color(1, 1, 1, 1);
        TimeStartSound.SetActive(false);
        this.GetComponent<BoxCollider2D>().enabled = true;
    }
}
