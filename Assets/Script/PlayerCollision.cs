using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManeger gameManeger;
    void Awake()
    {
        gameManeger = FindAnyObjectByType<GameManeger>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            gameManeger.AddScore(1);
            
        }
    }
}
