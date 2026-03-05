using UnityEngine;

public class EnemyGroup : MonoBehaviour
{
    public float moveDistance = 0.5f;
    public float moveDown = 0.5f;
    public float moveInterval = 1f;

    private float timer = 0;
    private int direction = 1;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= moveInterval)
        {
            transform.position += new Vector3(moveDistance * direction, 0, 0);
            timer = 0;

            CheckEdges();
        }
    }

    void CheckEdges()
    {
        if (transform.position.x > 8 || transform.position.x < -8)
        {
            direction *= -1;

            transform.position += Vector3.down * moveDown;
        }
    }
}