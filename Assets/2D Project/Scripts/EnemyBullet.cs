using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyBullet : MonoBehaviour
{
    public float speed = 6;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.down * speed;
        Destroy(gameObject, 5f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            return;
        }

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit!");
        }


        Destroy(gameObject);
    }
}

/*


using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyBullet : MonoBehaviour
{
    public float speed = 6;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.down * speed;
        Destroy(gameObject, 5f);
    }
}


*/