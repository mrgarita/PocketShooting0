using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // 弾の発射スピード
    public float Speed;
    // 爆破エフェクト
    public GameObject ExplosionEffect;
    // 効果音
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            // 得点アップ
            GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

            // 爆破エフェクト
            Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(se, transform.position);

            // ぶつかった相手を破壊
            Destroy(col.gameObject);
            // 弾を破壊
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, Speed, 0) * Time.deltaTime;
        if(transform.position.y >= 5.5f)
        {
            Destroy(gameObject);
        }
    }
}
