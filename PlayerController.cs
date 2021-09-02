using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 方向キーで入力された横軸の値を取得
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        // 現在位置にx,y の値を加算する
        transform.position += new Vector3(x, y, 0) * Time.deltaTime * Speed;

        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown("z"))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
