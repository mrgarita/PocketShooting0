using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
  // 敵のプレハブ
  public GameObject enemyPrefab;
  // 敵2のプレハブ
  public GameObject enemy2Prefab;
  // ボスのプレハブ
  public GameObject bossPrefab;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (GameObject.Find("GameMain").GetComponent<GameController>().status == STATUS.GAME)
    {
      // 敵をランダムに生成
      if (Random.Range(0, 300) == 1)
      {
        Vector3 pos = new Vector3(Random.Range(-2.2f, 2.2f), 5.5f, 0);  // 画面上方に生成
        Instantiate(enemyPrefab, pos, Quaternion.identity);
      }

      // 敵2をランダムに生成
      if (Random.Range(0, 500) == 1)
      {
        Vector3 pos = new Vector3(Random.Range(-2.2f, 2.2f), 5.5f, 0);  // 画面上方に生成
        Instantiate(enemy2Prefab, pos, Quaternion.identity);
      }

      // ボスの出現条件
      int score = GameObject.Find("Canvas").GetComponent<UIController>().GetScore();
      if (score >= 50)
      {
        // ゲームの状態をボス戦に変更
        GameObject.Find("GameMain").GetComponent<GameController>().status = STATUS.BOSS;
        // ボスを出現させる
        Instantiate(bossPrefab, new Vector3(0, 7f, 0), Quaternion.identity);
      }
    }
  }
}
