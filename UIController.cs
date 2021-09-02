using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    int score;
    public GameObject scoreText;

    public void AddScore()
    {
        score += 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: " + score.ToString("D4");
    }
}
