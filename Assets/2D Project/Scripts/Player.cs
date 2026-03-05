using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootOffsetTransform;

    public float moveSpeed = 8f;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        MovePlayer();

        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject shot = Instantiate(bulletPrefab, shootOffsetTransform.position, Quaternion.identity);

            Destroy(shot, 3f);

            animator.SetTrigger("Shot trigger");
        }
    }

    void MovePlayer()
    {
        float move = 0;

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            move = -1;
        }

        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            move = 1;
        }

        Vector3 pos = transform.position;
        pos.x += move * moveSpeed * Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, -8f, 8f);
        transform.position = pos;
    }
}


/* using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootOffsetTransform;

    void Start()
    {
        // todo - get and cache animator
    }
    
    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject shot = Instantiate(bulletPrefab, shootOffsetTransform.position, Quaternion.identity);
            Debug.Log("Bang!");

            // todo - destroy the bullet after 3 seconds
            // todo - trigger shoot animation
        }
        
        GetComponent<Animator>().SetTrigger("Shot trigger");
    }
    
}
 */