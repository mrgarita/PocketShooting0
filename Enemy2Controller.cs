using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{
    public float Speed;     // 落下速度
    public float vy;            // 加速度
    float pointY;               // 跳ねるY軸の位置（ランダム）
    float angle;                // 回転角度

    // Start is called before the first frame update
    void Start()
    {
        // 下方向に移動する
        Speed = -Speed;
        vy = -vy;

        // 跳ねる位置をランダムで設定
        pointY = Random.Range(-4.5f, -2.0f);

        // 回転角度設定
        angle = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // 上下に跳ねる動き
        transform.position += new Vector3(0, Speed * Time.deltaTime, 0);
        Speed += vy;

        if (transform.position.y < pointY)  // 跳ねる位置
        {
            Speed = -Speed;
        }

        // 回転させる
        transform.Rotate(0, 0, -angle);
    }
}
