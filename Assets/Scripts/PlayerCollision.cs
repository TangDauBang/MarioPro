using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;
    private AudioManager audioManager;

    void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        audioManager = FindAnyObjectByType<AudioManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Hit Coin");
            audioManager.PlayCoinSound();
            gameManager.AddScore(1);
        }
        else if (collision.CompareTag("Trap"))
        {
            Debug.Log("Hit Trap");
            gameManager.GameOver();
        }
        else if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Hit Enemy");
            gameManager.GameOver();
        }
        else if (collision.CompareTag("Key"))
        {
            Debug.Log("You Win");
            gameManager.GameWin();
        }
    }
}
