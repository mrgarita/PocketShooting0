using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // 弾の発射スピード
    public float Speed;
    // 爆破エフェクト（プレハブ）
    public GameObject ExplosionEffect;
    // 効果音
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // シーン上のオブジェクトと接触したときの処理
    private void OnTriggerEnter2D(Collider2D col)
    {
        // 敵だったら
        if(col.gameObject.tag == "Enemy")
        {
            // 得点アップ
            GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

            // 爆破エフェクト
            Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            // 効果音再生
            AudioSource.PlayClipAtPoint(se, new Vector3(0.0f, 0.0f, -10.0f));

            // ぶつかった相手を破壊
            Destroy(col.gameObject);

            // 弾を破壊
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        // 下から上に弾を移動
        transform.position += new Vector3(0, Speed, 0) * Time.deltaTime;

        // 画面上方に消えたら弾を消去
        if(transform.position.y >= 5.5f)
        {
            Destroy(gameObject);
        }
    }
}
