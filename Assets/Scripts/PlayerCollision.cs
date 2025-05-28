using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;
    private AudioManager audioManager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        audioManager = FindAnyObjectByType<AudioManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin")){
            audioManager.PlayCoinSound();
            gameManager.AddScore(1);
            Destroy(collision.gameObject);
            Debug.Log("Hit Coin");
        }
        else if (collision.CompareTag("Trap")){
            gameManager.GameOver();
            Debug.Log("Hit Trap");
        }
        else if (collision.CompareTag("Enemy"))
        {
            gameManager.GameOver();
            Debug.Log("Hit Enemy");
        }
        else if (collision.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            gameManager.GameWin();
            Debug.Log("Win");
        }
    }
}
