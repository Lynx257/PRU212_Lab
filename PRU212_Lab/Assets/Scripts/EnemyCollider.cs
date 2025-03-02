using UnityEngine;
using UnityEngine.Events;

public class EnemyCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public UnityEvent OnDied;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            OnDied.Invoke();
        }
    }
}
