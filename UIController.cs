using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
  public Text scoreText;    // 点数表示のUI Text
  public Text messageText;  // ゲームクリア・ゲームオーバーの表示用
  int score;                // 得点保存用

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
  }

  // Update is called once per frame
  void Update()
  {
    // 0埋め4桁表示で得点を表示
    scoreText.text = "Score: " + score.ToString("D4");

    // ゲームクリア・ゲームオーバーの表示
    if(GameObject.Find("GameMain").GetComponent<GameController>().status == STATUS.GAMECLEAR)
    {
      messageText.color = new Color(255, 255, 0, 0.7f);
      messageText.text = "GAME CLEAR!";
    }
    else if (GameObject.Find("GameMain").GetComponent<GameController>().status == STATUS.GAMEOVER)
    {
      messageText.color = new Color(255, 255, 255, 0.7f);
      messageText.text = "GAME OVER!";
    }
  }
}
