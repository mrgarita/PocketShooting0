using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // プレイヤーの移動速度
    public float Speed;
    // 弾のプレハブ
    public GameObject bulletPrefab;
    // プレイヤーの位置
    Vector3  p;

    // Start is called before the first frame update
    void Start()
    {
        // プレイヤーの初期位置を設定
        p= new Vector3(transform.position.x, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // ゲームパッド・方向キーで入力された値を取得
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
 
        // 現在位置に入力値（x,y）を加算する
        p += new Vector3(x, y, 0) * Time.deltaTime * Speed;

        // プレイヤーの移動範囲を設定
        if(p.x > 2.7f)
        {
            p.x = 2.7f;
        }
        else if(p.x < -2.7f)
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
}
