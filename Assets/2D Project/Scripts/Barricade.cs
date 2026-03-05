using UnityEngine;

public class Barricade : MonoBehaviour
{
    public int health = 5;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("bullet"))
        {
            Destroy(collision.gameObject);
            health--;
            transform.localScale *= 0.9f;

            if (health <= 0)
                Destroy(gameObject);
        }
    }
}