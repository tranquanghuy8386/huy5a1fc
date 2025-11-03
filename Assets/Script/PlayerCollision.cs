using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManeger gameManeger;
    private AudioManeger audioManeger;  
    void Awake()
    {
        gameManeger = FindAnyObjectByType<GameManeger>();
        audioManeger = FindAnyObjectByType<AudioManeger>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            audioManeger.PlayCoinSound();
            gameManeger.AddScore(1);

        }
        else if (collision.CompareTag("Trap"))
        {
            gameManeger.GameOver();

        }

        else if (collision.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            gameManeger.GameWin();

        }
        else if (collision.CompareTag("Enemy"))
        {
            gameManeger.GameOver();

        }
        
        
    }
    
}
