using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ゲームの状態
public enum STATUS{
  GAME,     // ゲーム中
  BOSS,     // ボス戦
  GAMEOVER, // ゲームオーバー
  GAMECLEAR // ゲームクリア
}

public class GameController : MonoBehaviour
{
  public STATUS status;

  // Start is called before the first frame update
  void Start()
  {
    status = STATUS.GAME;
  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
