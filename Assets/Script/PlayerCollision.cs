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
            gameManeger.AddScore(1);
            Debug.Log("Hit Coin");
        }
    }
}
