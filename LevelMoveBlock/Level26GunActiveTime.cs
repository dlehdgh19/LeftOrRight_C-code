using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level26GunActiveTime : MonoBehaviour
{
    public GameObject Gun1;
    public GameObject Gun2;
    public GameObject Gun3;
    public GameObject Gate;
    private float ActiveTime = 0;
    public GameObject GateSound;
    public static bool GateOpenbool = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ActiveTime += Time.deltaTime;
        if(ActiveTime > 15)
        {
            Gun2.SetActive(true);
        }
        if (ActiveTime > 30)
        {
            Gun3.SetActive(true);
        }
        if (ActiveTime > 45)
        {
            Gate.SetActive(false);
            GateSound.SetActive(true);
            GateOpenbool = true;
        }
    }

    private void OnEnable()
    {
        ActiveTime = 0;
        Gun2.SetActive(false);
        Gun3.SetActive(false);
        Gate.SetActive(true);
        GateSound.SetActive(false);
    }

    private void OnDisable()
    {
        ActiveTime = 0;
        Gun2.SetActive(false);
        Gun3.SetActive(false);
        Gate.SetActive(true);
        GateSound.SetActive(false);
    }
}
