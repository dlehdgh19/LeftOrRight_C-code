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

    //���� ������ ������ ȸ���ϸ鼭 ���� ����������(�Ҹ��� �鸮��)
}
