using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D collider){
        if (collider.gameObject.tag == "Player"){

            GameControler.instance.totalScore += Score;
            GameControler.instance.UpdateScoreText();

            Destroy(gameObject);
        }
    }
}
