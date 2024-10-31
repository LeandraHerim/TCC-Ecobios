using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int vida;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
             Debug.Log("Colisão detectada com o inimigo!");
            boss.instance.vida--; // Reduz a vida

            if(boss.instance.vida < 0){
                Destroy(collision.gameObject); // Destroi o inimigo
            }
            Destroy(gameObject); // Destroi a bala
        }
    }

    void Update()
    {
        // Destruir a bala após um tempo para evitar que ela continue para sempre
        Destroy(gameObject, 5f); // Destruir após 5 segundos
    }

    public static implicit operator Bullet(boss v)
    {
        throw new NotImplementedException();
    }
}

