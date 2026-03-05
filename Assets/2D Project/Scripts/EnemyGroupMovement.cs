using UnityEngine;

public class EnemyGroupMovement : MonoBehaviour
{
    public float moveStep = 0.5f;
    public float moveDown = 0.5f;
    public float moveInterval = 2.5f;

    float timer;
    int direction = 1;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= moveInterval)
        {
            transform.position += Vector3.right * moveStep * direction;
            timer = 0;

            CheckEdges();
        }
    }

    void CheckEdges()
    {
        foreach (Transform enemy in transform)
        {
            if (enemy.position.x > 8 || enemy.position.x < -8)
            {
                direction *= -1;
                transform.position += Vector3.down * moveDown;
                break;
            }
        }
    }
}