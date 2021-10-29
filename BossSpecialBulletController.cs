using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpecialBulletController : MonoBehaviour
{
    // 弾の速度
    public float Speed;
    // 発射音
    public AudioClip Se;

    // Start is called before the first frame update
    void Start()
    {
        // 起動時に発射音を鳴らす
        AudioSource.PlayClipAtPoint(Se, new Vector3(0, 0, -10f));
    }

    // Update is called once per frame
    void Update()
    {
        // 弾を移動する（下方向）
        transform.position += Vector3.down * Speed * Time.deltaTime;

        // 画面下に消えたら弾を削除
        if (transform.position.y < -5.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
