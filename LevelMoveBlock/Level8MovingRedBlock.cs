using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level8MovingRedBlock : MonoBehaviour
{
    public GameObject RedBlock;
    public float Speed;
    public float Length;
    private float MoveTime;
    // Start is called before the first frame update
    void Start()
    {
        MoveTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTime += Time.deltaTime * Speed;
        RedBlock.transform.localPosition = new Vector3(RedBlock.transform.localPosition.x, Mathf.Sin(MoveTime) * Length, 0);
    }

    private void OnDisable()
    {
        MoveTime = 0;
    }

    private void OnEnable()
    {
        MoveTime = 0;
    }
}
