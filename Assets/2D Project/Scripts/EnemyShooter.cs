using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    void Update()
    {
        if (Random.value < 0.05f)
        //if (Random.value < 0.001f)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}
/*
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject bulletPrefab;

    
    
    void Start()
    {
        InvokeRepeating("Shoot", 2f, 3f);
    }

    
    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
    
}*/