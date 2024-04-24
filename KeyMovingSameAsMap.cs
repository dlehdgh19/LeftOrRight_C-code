using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMovingSameAsMap : MonoBehaviour
{
    public GameObject Map;
    private float Spiningfloat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, Map.transform.rotation.z);
    }

    //공이 닿음시 빠르게 회전하면서 점점 투명해지기(소리도 들리기)
}
