using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level26SpawnBullet : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject BulletPrefab;
    public float Speed;
    private float ShootTime = 0;
    private bool FireOncebool = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootTime += Time.deltaTime;
        if(ShootTime >= 3)
        {
            if(FireOncebool == false && Level26GunActiveTime.GateOpenbool == false)
            {
                var bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = BulletSpawnPoint.up * (-Speed);
                FireOncebool = true;
            }
            
        }
        if(ShootTime > 6f)
        {
            FireOncebool = false;
            ShootTime = 3f;
        }
        
        
    }

    private void OnEnable()
    {
        ShootTime = 0;
        FireOncebool = false;
    }

    private void OnDisable()
    {
        ShootTime = 0;
        FireOncebool = false;
    }
}
