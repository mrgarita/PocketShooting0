using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ゲームの状態
public enum STATUS{
  GAME,     // ゲーム中
  BOSS,     // ボス戦
  GAMEOVER, // ゲームオーバー
  GAMECLEAR, // ゲームクリア
  TITLE      // タイトル
}

public class GameController : MonoBehaviour
{
  public STATUS status;

  // ゲーム終了（タイトル画面へ）
  void ExitGame()
  {
    SceneManager.LoadScene("TitleScene");
  }

  // Start is called before the first frame update
  void Start()
  {
    status = STATUS.GAME;
  }

  // Update is called once per frame
  void Update()
  {
    // タイトル画面への遷移
    if(status == STATUS.TITLE)
    {
      Invoke("ExitGame", 6);  // 6秒後にExitGameを実行
    }
    else if(status == STATUS.GAMECLEAR)
    {
      // ボスを倒していれば状態をタイトルにする
      status = STATUS.TITLE;
    }
  }
}
