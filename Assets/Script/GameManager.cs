using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject rain;
    public static GameManager I;
    public Text scoreText;
    int totalScore;

    private void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0, 0.1f);
    }

    void makeRain()
    {
        Instantiate(rain);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int score)
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();
    }
}
