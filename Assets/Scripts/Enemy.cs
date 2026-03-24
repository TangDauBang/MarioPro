using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 2.0f;
    [SerializeField] private float distance = 5.0f;
    private Vector3 startPos;
    private bool moveRight = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float rightBound = startPos.x + distance;
        float leftBound = startPos.x - distance;
        if (moveRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= rightBound)
            {
                Flip();
                moveRight = false;
            }
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= leftBound)
            {
                Flip();
                moveRight = true;
            }
        }

    }

    void Flip()
    {
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
