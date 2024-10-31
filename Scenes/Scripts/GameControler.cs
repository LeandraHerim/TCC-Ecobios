using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControler : MonoBehaviour
{
    public int totalScore;
    public TextMeshProUGUI scoreText;

    public static GameControler instance; 

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreText(){
        scoreText.text =  totalScore.ToString();
    }
}
