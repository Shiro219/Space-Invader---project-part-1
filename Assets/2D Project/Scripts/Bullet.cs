using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public float speed = 50;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * speed;
    }
}

/* using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public float speed = 50;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * speed;
        Debug.Log("Wwweeeeee");
    }
}
 */