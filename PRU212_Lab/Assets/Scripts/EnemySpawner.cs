using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    int period;
    private float time = 0;
    private Camera mainCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > period)
        {
            SpawnEnemy();
            time = 0;
        }
    }

    void SpawnEnemy()
    {
        GameObject enemy = EnemyPool.enemyPool.GetEnemyPool();
        if (enemy != null)
        {
            Vector2 spawnPosition = GetSpawnPosition();
            enemy.transform.position = spawnPosition;
            enemy.SetActive(true);
        }
    }

    Vector2 GetSpawnPosition()
    {
        float camHeight = 2f * mainCamera.orthographicSize;
        float camWidth = camHeight * mainCamera.aspect;

        float spawnX = 0f, spawnY = mainCamera.transform.position.y + (camHeight / 2) + 1f;

        int spawnZone = Random.Range(0, 3);

        switch (spawnZone)
        {
            case 0:
                spawnX = Random.Range(mainCamera.transform.position.x - (camWidth / 2),
                                      mainCamera.transform.position.x + (camWidth / 2));
                break;

            case 1:
                spawnX = mainCamera.transform.position.x - (camWidth / 2) - 1f;
                spawnY = Random.Range(mainCamera.transform.position.y,
                                      mainCamera.transform.position.y + (camHeight / 2));
                break;

            case 2:
                spawnX = mainCamera.transform.position.x + (camWidth / 2) + 1f;
                spawnY = Random.Range(mainCamera.transform.position.y,
                                      mainCamera.transform.position.y + (camHeight / 2));
                break;
        }

        return new Vector2(spawnX, spawnY);
    }


}
