using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSave : MonoBehaviour
{
    public SpriteRenderer Rend;
    public GameObject SaveTimeSound;
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
            NeedleControl.Savebool = true;
            Rend.color = new Color(1, 1, 1, 0);
            SaveTimeSound.SetActive(true);
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnEnable()
    {
        Rend.color = new Color(1, 1, 1, 1);
        this.GetComponent<BoxCollider2D>().enabled = true;
        SaveTimeSound.SetActive(false);
    }

    private void OnDisable()
    {
        Rend.color = new Color(1, 1, 1, 1);
        this.GetComponent<BoxCollider2D>().enabled = true;
        SaveTimeSound.SetActive(false);
    }
}
