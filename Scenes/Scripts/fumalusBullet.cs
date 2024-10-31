using UnityEngine;

public class fumalusBullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
             Debug.Log("Colisão detectada com o Player!");
            Life.instance.vida--; // Reduz a vida

            if(Life.instance.vida < 0){
                Destroy(collision.gameObject); // Destroi o Player
            }
            Destroy(gameObject); // Destroi a bala
        }
    }

    void Update()
    {
        
        Destroy(gameObject, 3f);
    }
}
