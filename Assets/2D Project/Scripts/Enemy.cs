using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float scoreValue = 10;

    public delegate void EnemyDiedFunc(float points);
    public static event EnemyDiedFunc OnEnemyDied;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            OnEnemyDied?.Invoke(scoreValue);
        }
    }
}

/* using UnityEngine;

public class Enemy : MonoBehaviour
{

    public delegate void EnemyDiedFunc(float points);

    public static event EnemyDiedFunc OnEnemyDied;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");

        if (collision.gameObject.layer == LayerMask.NameToLayer("bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
            OnEnemyDied.Invoke(10);
        }
        // todo - destroy the bullet
        // todo - trigger death animation
    }
} */
