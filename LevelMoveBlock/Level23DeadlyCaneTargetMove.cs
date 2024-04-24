using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level23DeadlyCaneTargetMove : MonoBehaviour
{
    public GameObject DeadlyCane;
    public GameObject AlertBlock;
    public GameObject AlertSound;
    public GameObject MovingSound;
    private Vector3 FirstPosition;
    public GameObject Ball_X_Position;
    private Vector3 LastPosition;
    private float MovingTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        FirstPosition = new Vector3(0, 15, 0);
        AlertBlock.SetActive(false);
        AlertSound.SetActive(false);
        MovingSound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MovingTime += Time.deltaTime;
        if(MovingTime > 0 && MovingTime < 4)
        {
            DeadlyCane.transform.localPosition = new Vector3(Ball_X_Position.transform.localPosition.x, 15, 0);
            LastPosition.x = Ball_X_Position.transform.localPosition.x;
            AlertBlock.transform.localPosition = new Vector3(Ball_X_Position.transform.localPosition.x, 0, 0);
        }
        if(MovingTime > 4 && MovingTime < 5)
        {
            
            AlertBlock.SetActive(true);
            AlertSound.SetActive(true);
        }
        if(MovingTime > 5 && MovingTime < 6)
        {
            DeadlyCane.transform.localPosition = new Vector3(LastPosition.x, 15 - 12f * (MovingTime - 5), 0);
            AlertBlock.SetActive(false);
            AlertSound.SetActive(false);
            
        }
        if(MovingTime > 6 && MovingTime < 7)
        {
            MovingSound.SetActive(true);
        }
        if(MovingTime > 7 && MovingTime < 9)
        {
            
            DeadlyCane.transform.localPosition = new Vector3(LastPosition.x, 3 + 6f * (MovingTime - 7), 0);
            
        }
        if(MovingTime > 9)
        {
            MovingSound.SetActive(false);
            DeadlyCane.transform.localPosition = new Vector3(LastPosition.x, 15, 0);
            MovingTime = 2.5f;
        }

    }

    private void OnEnable()
    {
        MovingTime = 0;
        AlertBlock.SetActive(false);
        AlertSound.SetActive(false);
        MovingSound.SetActive(false);
    }

    private void OnDisable()
    {
        MovingTime = 0;
        AlertBlock.SetActive(false);
        AlertSound.SetActive(false);
        MovingSound.SetActive(false);
    }
}
