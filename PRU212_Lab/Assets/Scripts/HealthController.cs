using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int health;
    public int numberOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.gameObject.CompareTag("Player"))
        {
            DisplayHeart();
        }
    }

    void DisplayHeart()
    {
        if (health > numberOfHearts)
        {
            health = numberOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health -= 1;
        }
    }
}
