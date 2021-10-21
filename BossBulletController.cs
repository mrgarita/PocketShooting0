using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletController : MonoBehaviour
{
    // 弾の速度
    public float Speed;
    // 弾の移動ベクトル
    Vector3 vec;

    // 外部スクリプトから角度と速度を指定したいため
    public void Create(float angle)
    {
        // 角度をラジアンに変換
        float rad = angle * Mathf.Deg2Rad;
        // ラジアンから進行方向を設定
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0f);
        // 方向に速度を掛け合わせて移動ベクトルを求める
        vec = direction * Speed * Time.deltaTime;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 弾を移動する
        transform.position += vec;

        // 画面外に出たら弾を削除
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(this.gameObject);
        }
    }
}
