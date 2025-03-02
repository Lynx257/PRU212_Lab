using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public static BulletPool bulletPooling;
    public List<GameObject> poolBullets;
    public GameObject bulletPrefab;
    public int amountOfPool;

    void Awake()
    {
        bulletPooling = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        poolBullets = new List<GameObject>();
        GameObject temp;
        for (int i = 0; i < amountOfPool; i++)
        {
            temp = Instantiate(bulletPrefab);
            temp.SetActive(false);
            poolBullets.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public GameObject GetBulletPool()
    {
        for (int i = 0; i < amountOfPool; i++)
        {
            if (!poolBullets[i].activeInHierarchy)
            {
                return poolBullets[i];
            }
        }
        return null;
    }
}
