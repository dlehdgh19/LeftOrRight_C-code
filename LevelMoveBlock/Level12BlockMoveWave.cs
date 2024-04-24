using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level12BlockMoveWave : MonoBehaviour
{
    public bool Movingbool;
    public Vector3 LocalPosition;
    public float Movingterm;
    private float Term;

    // Start is called before the first frame update
    void Start()
    {
        LocalPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Term += Movingterm * Time.deltaTime;
        if(Term > 0 && Term < 3f)
        {
            if(Movingbool == true)
            {
                transform.localPosition = new Vector3(LocalPosition.x, (LocalPosition.y + Term) * 0.6f, 0);
            }
            if (Movingbool == false)
            {
                transform.localPosition = new Vector3(LocalPosition.x, (LocalPosition.y + 3f - Term) * 0.6f, 0);
            }
        }
        if (Term >= 5 && Term < 8f)
        {
            if (Movingbool == true)
            {
                transform.localPosition = new Vector3(LocalPosition.x, (LocalPosition.y - (Term - 8f)) * 0.6f, 0);
            }
            if (Movingbool == false)
            {
                transform.localPosition = new Vector3(LocalPosition.x, (LocalPosition.y + Term - 5) * 0.6f, 0);
            }
            
        }
        if (Term >= 10)
        {
            Term = 0;
        }

    }
}
