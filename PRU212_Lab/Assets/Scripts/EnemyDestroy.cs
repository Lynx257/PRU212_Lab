using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public void DestroyEnemy(float delay)
    {
        Invoke(nameof(DisableEnemy), delay);
    }

    private void DisableEnemy()
    {
        gameObject.SetActive(false);
    }
}
