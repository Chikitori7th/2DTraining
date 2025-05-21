using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin")){
            gameManager.AddScore(1);
            Destroy(collision.gameObject);
            Debug.Log("Hit Coin");
        }
        else if (collision.CompareTag("Trap")){
            gameManager.GameOver();
            Debug.Log("Hit Trap");
        }
    }
}
