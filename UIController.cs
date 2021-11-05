using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
  public GameObject scoreText;    // 点数表示のUI Text
  public GameObject messageText;  // ゲームクリア・ゲームオーバーの表示用
  int score;                      // 得点保存用

  // 得点アップ用メソッド
  public void AddScore()
  {
    score += 10;
  }

  // 得点取得メソッド
  public int GetScore()
  {
    return score;
  }

  // Start is called before the first frame update
  void Start()
  {
    // 得点の0クリアとシーン上のUI Text（得点用）を取得
    score = 0;
    scoreText = GameObject.Find("Score");
    // メッセージ用のUI Textを取得
    messageText = GameObject.Find("Message");
  }

  // Update is called once per frame
  void Update()
  {
    // 0埋め4桁表示で得点を表示
    scoreText.GetComponent<Text>().text = "Score: " + score.ToString("D4");

    // ゲームクリア・ゲームオーバーの表示
    if(GameObject.Find("GameMain").GetComponent<GameController>().status == STATUS.GAMECLEAR)
    {
      messageText.GetComponent<Text>().color = new Color(255, 255, 0, 0.7f);
      messageText.GetComponent<Text>().text = "GAME CLEAR!";
    }
    else if (GameObject.Find("GameMain").GetComponent<GameController>().status == STATUS.GAMEOVER)
    {
      messageText.GetComponent<Text>().color = new Color(255, 255, 255, 0.7f);
      messageText.GetComponent<Text>().text = "GAME OVER!";
    }
  }
}
