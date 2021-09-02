using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject scoreText;    // 点数表示のUI Text
    int score;                                      // 得点保存用

    // 得点アップ用メソッド
    public void AddScore()
    {
        score += 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        // 得点の0クリアとシーン上のUI Text（得点用）を取得
        score = 0;
        scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        // 0埋め4桁表示で得点を表示
        scoreText.GetComponent<Text>().text = "Score: " + score.ToString("D4");
    }
}
