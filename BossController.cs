﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
  // 爆破エフェクト（ボスを倒した時）
  public GameObject BossExplosionEffect;
  // 効果音（ボスを倒した時）
  public AudioClip BossSe;

  // ボスの移動スピード
  public float Speed;
  // ボスの体力
  public int BossHp;

  // ボスの弾幕攻撃用プレハブ
  public GameObject bossBulletNormal;
  // ボスの強化攻撃用プレハブ
  public GameObject bossBulletSpecial;
  // ボスの強化攻撃のON/OFF
  bool bossBulletSpecialFlg;

  // ボスのヒットカウント
  int HitCount;
  // ボスの位置
  Vector3 pos;

  // 弾幕発射角度設定
  float[] angles = { -60, -90, -120 };

  // 弾幕発射関数
  void CreateShot()
  {
    foreach (float angle in angles)
    {
      // 弾プレハブを生成
      GameObject shot = Instantiate(bossBulletNormal, transform.position, Quaternion.identity);
      BossBulletController s = shot.GetComponent<BossBulletController>();     // オブジェクトにアタッチしたBossBulletControllerスクリプトを取得
      s.Create(angle);    // 角度を設定
    }
  }

  // ボスのヒットカウント加算
  public void AddHitCount()
  {
    HitCount += 1;
    Debug.Log("Hit: " + HitCount);
  }

  // Start is called before the first frame update
  void Start()
  {
    GetComponent<Collider2D>().enabled = false; // 登場した時は当たり判定無効化
    HitCount = 0;
    StartCoroutine(BossShot());     // ボス登場時の並列実行処理を設定
    bossBulletSpecialFlg = false;   // ボスの強化攻撃OFF
  }

  // Update is called once per frame
  void Update()
  {
    // ボスの現在位置取得
    pos = transform.position;

    // ボスの動き
    if (pos.y > 3.0f)   // 一定の高さまではボスが下に降りてくる
    {
      pos += Vector3.down * Time.deltaTime;
    }
    else                    // 途中からは左右に行ったり来たり
    {
      GetComponent<Collider2D>().enabled = true; // 当たり判定有効化
      // ボスの強化攻撃ON
      if (bossBulletSpecialFlg == false)
      {
        bossBulletSpecialFlg = true;        
        StartCoroutine(BossSpecialShot());
      }
      // 移動方向
      Vector3 vec = new Vector3(Speed, 0f, 0f);
      // 現在位置に加算
      pos += vec * Time.deltaTime;
      // 移動範囲チェック
      if (pos.x > 2.8f)
      {
        pos.x = 2.8f;
        Speed = -Speed;
      }
      else if (pos.x < -2.8f)
      {
        pos.x = -2.8f;
        Speed = -Speed;
      }
    }

    // ボスの位置を設定
    transform.position = pos;

    // ボスを倒したか？
    if (HitCount > BossHp)
    {
      GameObject.Find("GameMain").GetComponent<GameController>().status = STATUS.GAMECLEAR;
      // 爆破エフェクト
      Instantiate(BossExplosionEffect, transform.position, Quaternion.identity);
      // 爆破音
      AudioSource.PlayClipAtPoint(BossSe, new Vector3(0f, 0f, -10f));
      // ボスを消去
      Destroy(gameObject);
    }
  }

  // 並列実行処理：一定時間ごとにボスが弾幕を出す
  IEnumerator BossShot()
  {
    while (true)
    {
      CreateShot();
      yield return new WaitForSeconds(3f);    // 3秒ごと
    }
  }

  // 並列実行処理：一定時間ごとにボスが強化攻撃を出す
  IEnumerator BossSpecialShot()
  {
    while (true)
    {
      Instantiate(bossBulletSpecial, transform.position, Quaternion.identity);
      yield return new WaitForSeconds(5f);    // 5秒ごと
    }
  }
}