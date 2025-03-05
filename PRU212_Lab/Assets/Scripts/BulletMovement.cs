using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    private Score score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = FindFirstObjectByType<Score>();
    }

    void Update()
    {
        rb.linearVelocity = transform.up * speed;
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);

            if (score != null)
            {
                score.EnemyKilled();
            }
        }
    }
}
