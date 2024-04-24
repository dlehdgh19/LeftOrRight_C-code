using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleControl : MonoBehaviour
{
    
    public GameObject BigNeedle;
    public GameObject SaveNeedle;
    public GameObject BigCollider;
    public SpriteRenderer BigRend;
    public SpriteRenderer SaveRend;
    private float SpinTime = 0;
    private float RewindTime = 0;
    private int SpinInt = 0;
    private int SaveInt = 0;
    private bool Spinbool = false;
    public static bool TimeStartbool = false;
    public static bool Savebool = false;
    public static bool Rewindbool = false;
    public GameObject RewindSound;
    public GameObject StopNeedleSound;

    public GameObject SaveBlock1;
    public GameObject RewindBlock1;
    public GameObject SaveBlock2;
    public GameObject RewindBlock2;
    public GameObject SaveBlock3;
    public GameObject RewindBlock3;

    private int SpawnInt = 0;
    private bool Spawnbool = false;

    // Start is called before the first frame update
    void Start()
    {
        SaveBlock1.SetActive(false);
        RewindBlock1.SetActive(false);
        SaveBlock2.SetActive(false);
        RewindBlock2.SetActive(false);
        SaveBlock3.SetActive(false);
        RewindBlock3.SetActive(false);
        SpawnInt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(SpawnInt == 0)
        {
            SaveBlock1.SetActive(true);
            RewindBlock1.SetActive(true);
            SaveBlock2.SetActive(false);
            RewindBlock2.SetActive(false);
            SaveBlock3.SetActive(false);
            RewindBlock3.SetActive(false);
        }
        if (SpawnInt == 2)
        {
            SaveBlock2.SetActive(true);
            RewindBlock2.SetActive(true);
            SaveBlock1.SetActive(false);
            RewindBlock1.SetActive(false);
            SaveBlock3.SetActive(false);
            RewindBlock3.SetActive(false);
        }
        if (SpawnInt == 4)
        {
            SaveBlock3.SetActive(true);
            RewindBlock3.SetActive(true);
            SaveBlock1.SetActive(false);
            RewindBlock1.SetActive(false);
            SaveBlock2.SetActive(false);
            RewindBlock2.SetActive(false);
        }

        if (TimeStartbool == false)
        {
            BigNeedle.transform.localRotation = Quaternion.Euler(0, 0, 0);
            SaveNeedle.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if(Rewindbool == false && TimeStartbool == true)
        {
            SpinTime += Time.deltaTime;
            if (SpinTime > 0.45f)
            {
                SpinInt -= 6;
                SpinTime = 0f;
            }
        }
        
        if (Savebool == false && Rewindbool == false && TimeStartbool == true)
        {
            
            RewindSound.SetActive(false);
            StopNeedleSound.SetActive(false);
            RewindTime = 0;
            BigRend.color = new Color(1, 0, 0, 1);
            BigCollider.GetComponent<PolygonCollider2D>().enabled = true;
            BigNeedle.transform.localRotation = Quaternion.Euler(0, 0, SpinInt);
            SaveNeedle.transform.localRotation = Quaternion.Euler(0, 0, SpinInt);
            SaveInt = SpinInt;
        }
        if (Savebool == true && Rewindbool == false && TimeStartbool == true)
        {
            if(Spawnbool == false)
            {
                SpawnInt += 1;
                Spawnbool = true;
            }
            
            RewindSound.SetActive(false);
            StopNeedleSound.SetActive(false);
            RewindTime = 0;
            BigRend.color = new Color(1, 0, 0, 1);
            BigCollider.GetComponent<PolygonCollider2D>().enabled = true;
            BigNeedle.transform.localRotation = Quaternion.Euler(0, 0, SpinInt);
            SaveNeedle.transform.localRotation = Quaternion.Euler(0, 0, SaveInt);
            
        }
        if (Savebool == true && Rewindbool == true && TimeStartbool == true)
        {
            StopNeedleSound.SetActive(true);
            RewindTime += Time.deltaTime;
            BigRend.color = new Color(1, 0.5f, 0, 0.6f);
            BigCollider.GetComponent<PolygonCollider2D>().enabled = false;
            if(RewindTime > 1f && ((25 * (RewindTime - 1f) + SpinInt) < SaveInt))
            {
                RewindSound.SetActive(true);
                BigNeedle.transform.localRotation = Quaternion.Euler(0, 0, (25 * (RewindTime - 1f) + SpinInt));
                SaveNeedle.transform.localRotation = Quaternion.Euler(0, 0, SaveInt);
            }
            if (RewindTime > 1f && ((25 * (RewindTime - 1f) + SpinInt) >= SaveInt))
            {
                if (Spawnbool == true)
                {
                    SpawnInt += 1;
                    Spawnbool = false;
                }
                SpinInt = SaveInt;
                StopNeedleSound.SetActive(false);
                RewindSound.SetActive(false);
                Savebool = false;
                Rewindbool = false;
                RewindTime = 0;
            }

        }
    }

    private void OnEnable()
    {
        SpinInt = 0;
        SpinTime = 0;
        SaveInt = 0;
        RewindTime = 0;
        
        Spinbool = false;
        Savebool = false;
        Rewindbool = false;
        TimeStartbool = false;
        SaveRend.color = new Color(0, 1, 0, 0.6f);
        BigRend.color = new Color(1, 0, 0, 1);
        BigCollider.GetComponent<PolygonCollider2D>().enabled = true;
        RewindSound.SetActive(false);
        StopNeedleSound.SetActive(false);
        BigNeedle.transform.rotation = Quaternion.Euler(0, 0, 0);
        SaveNeedle.transform.rotation = Quaternion.Euler(0, 0, 0);

        SaveBlock1.SetActive(false);
        RewindBlock1.SetActive(false);
        SaveBlock2.SetActive(false);
        RewindBlock2.SetActive(false);
        SaveBlock3.SetActive(false);
        RewindBlock3.SetActive(false);
        SpawnInt = 0;
        Spawnbool = false;
    }

    private void OnDisable()
    {
        SpinInt = 0;
        SpinTime = 0;
        SaveInt = 0;
        RewindTime = 0;
        
        Spinbool = false;
        Savebool = false;
        Rewindbool = false;
        TimeStartbool = false;
        SaveRend.color = new Color(0, 1, 0, 0.6f);
        BigRend.color = new Color(1, 0, 0, 1);
        BigCollider.GetComponent<PolygonCollider2D>().enabled = true;
        RewindSound.SetActive(false);
        StopNeedleSound.SetActive(false);
        BigNeedle.transform.rotation = Quaternion.Euler(0, 0, 0);
        SaveNeedle.transform.rotation = Quaternion.Euler(0, 0, 0);

        SaveBlock1.SetActive(false);
        RewindBlock1.SetActive(false);
        SaveBlock2.SetActive(false);
        RewindBlock2.SetActive(false);
        SaveBlock3.SetActive(false);
        RewindBlock3.SetActive(false);
        SpawnInt = 0;
        Spawnbool = false;
    }
}
