using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  // プレイヤーの移動速度
  public float Speed;
  // 弾のプレハブ
  public GameObject bulletPrefab;
  // ゲームオーバー時のプレハブ
  public GameObject kyaPrefab;
  // ゲームオーバー時の効果音
  public AudioClip gameOverSe;

  // プレイヤーの位置
  Vector3  p;
  // プレイヤーの大きさ
  Vector3 ps;

  // ゲーム中の処理
  void Game()
  {
    // ゲームパッド・方向キーで入力された値を取得
    float x = Input.GetAxis("Horizontal");
    float y = Input.GetAxis("Vertical");

    // 現在位置に入力値（x,y）を加算する
    p += new Vector3(x, y, 0) * Time.deltaTime * Speed;

    // プレイヤーの移動範囲を設定
    if (p.x > 2.7f)
    {
      p.x = 2.7f;
    }
    else if (p.x < -2.7f)
    {
      p.x = -2.7f;
    }
    if (p.y > 4.8f)
    {
      p.y = 4.8f;
    }
    else if (p.y < -4.8f)
    {
      p.y = -4.8f;
    }

    // プレイヤーの位置を決定
    transform.position = p;

    // ジョイパッドのAボタン　または　zキーが押されたら弾を発射
    if (Input.GetButtonDown("Fire1") || Input.GetKeyDown("z"))
    {
      Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
  }

  // ゲームオーバー時の処理
  void GameOver()
  {
    // ぐるぐる回転させる
    transform.Rotate(0.0f, 0.0f, -5.0f);

    // だんだん小さくなる
    ps.x -= 0.02f;
    ps.y -= 0.02f;

    // スケールが0未満になると逆に大きくなってしまうため0のままとする
    if (ps.x < 0.0f)
    {
      ps.x = 0;
      ps.y = 0;
      // プレイヤーが消えたらタイトルに戻る
      GameObject.Find("GameMain").GetComponent<GameController>().status = STATUS.TITLE;
      Destroy(gameObject);
    }

    // プレイヤーの大きさを設定
    transform.localScale = new Vector3(ps.x, ps.y, 0);
  }

  // Start is called before the first frame update
  void Start()
  {
    // プレイヤーの初期位置を設定
    p= new Vector3(transform.position.x, transform.position.y, 0);
    // プレイヤーの初期状態の大きさを保存（Scale）
    ps = new Vector3(transform.localScale.x, transform.localScale.y, 0);
  }

  // Update is called once per frame
  void Update()
  {
    if(GameObject.Find("GameMain").GetComponent<GameController>().status != STATUS.GAMEOVER)
    {
      Game();
    }
    else
    {
      GameOver();
    }
  }

  // 当たり判定
  private void OnTriggerEnter2D(Collider2D col)
  {
    // ゲーム中とボス戦の時のみ当たり判定をする
    if(GameObject.Find("GameMain").GetComponent<GameController>().status == STATUS.GAME || GameObject.Find("GameMain").GetComponent<GameController>().status == STATUS.BOSS)
    {
      if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Boss" || col.gameObject.tag == "EnemyBullet")
      {
        // 状態：ゲームオーバーにする
        GameObject.Find("GameMain").GetComponent<GameController>().status = STATUS.GAMEOVER;

        // 「きゃっ」プレハブを生成
        Instantiate(kyaPrefab, transform.position, Quaternion.identity);

        // 効果音再生
        AudioSource.PlayClipAtPoint(gameOverSe, new Vector3(0, 0, -10));
      }
    }
  }
}
