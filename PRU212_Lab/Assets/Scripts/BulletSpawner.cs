using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform firePoint;
    public float fireRate = 2f;
    private float nextFireTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        GameObject bullet = BulletPool.bulletPooling.GetBulletPool();
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (bullet != null)
        {
            bullet.transform.position = firePoint.transform.position;
            bullet.transform.rotation = firePoint.transform.rotation;
            bullet.SetActive(true);
        }
    }
}
