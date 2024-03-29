﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float Speed;     // 速度
    private float pointY;   // プレイヤーに向かってくるY軸の位置
    private float vx;           // X軸の移動量
    private GameObject player;  // プレイヤーオブジェクト取得用

    // Start is called before the first frame update
    void Start()
    {
        // プレイヤーに向かってくるY軸の位置
        pointY = Random.Range(2.0f, 3.0f);
        // 敵の初期位置とプレイヤーの位置によってX軸の移動方向を決定する（プレイヤーに向かってくるような設定）
        vx = 1.0f;
        player = GameObject.Find("Player");
        if(player.transform.position.x < transform.position.x)
        {
            vx = -vx;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 下に向かって移動する
        transform.position += new Vector3(0, -Speed, 0) * Time.deltaTime;

        // 一定の位置になるとプレイヤーに向かって移動する
        if(transform.position.y < pointY)
        {
            transform.position += new Vector3(vx, 0, 0) * Time.deltaTime;
        }

        // 画面の下に消えたらオブジェクト消去
        if(transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
}
