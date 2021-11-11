using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KumoController : MonoBehaviour
{
  float Speed;  // 移動速度
  float sy;     //　最初のy座標

  // 雲の座標を設定（シーンの右端でY座標と移動速度はランダム）
  void SetPosition()
  {
    Speed = Random.Range(1f, 3f); // 移動速度をランダムで設定
    sy = Random.Range(-5f, 5f);   // Y座標をランダムで設定
    transform.position = new Vector3(4.3f, sy, 0);  // 初期位置を設定
  }

  // Start is called before the first frame update
  void Start()
  {
    SetPosition();
  }

  // Update is called once per frame
  void Update()
  {
    // 雲の移動
    transform.position += Vector3.left * Speed * Time.deltaTime;

    // 左端に消えたら位置と速度を変えて右端から登場させる
    if(transform.position.x < -4.3f)
    {
      SetPosition();
    }
  }
}
