using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public static EnemyPool enemyPool;
    public List<GameObject> poolEnemies;
    public GameObject enemyPrefab;
    public int amountOfPool;

    void Awake()
    {
        enemyPool = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        poolEnemies = new List<GameObject>();
        GameObject temp;
        for (int i = 0; i < amountOfPool; i++)
        {
            temp = Instantiate(enemyPrefab);
            temp.SetActive(false);
            poolEnemies.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject GetEnemyPool()
    {
        for (int i = 0; i < amountOfPool; i++)
        {
            if (!poolEnemies[i].activeInHierarchy)
            {
                return poolEnemies[i];
            }
        }
        return null;
    }
}
