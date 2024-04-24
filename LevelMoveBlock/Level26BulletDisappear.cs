using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level26BulletDisappear : MonoBehaviour
{
    private float DisappearTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Destroy(gameObject,4f);

        if(Ball.Deadbool == true)
        {
            Destroy(gameObject, 0f);
        }
        
    }
}
