using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyaController : MonoBehaviour
{	
	// Start is called before the first frame update
    void Start()
    {
		// プレイヤーの位置にする
		transform.position = GameObject.Find("Player").transform.position;
		// ちょっと右上にはねて落ちていく
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		Vector2 force = new Vector2(1.0f, 5.0f);
		rb.AddForce(force, ForceMode2D.Impulse);
	}

	// Update is called once per frame
	void Update()
    {
 
	}
}
