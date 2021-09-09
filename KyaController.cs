using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyaController : MonoBehaviour
{
	GameObject player;
	Vector3 pos;
	float vx, vy;
	int timer;
    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.Find("Player");
		vx = 0.5f;
		vy = 0.1f;
		pos = player.transform.position;
		transform.position = pos;
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		Vector2 force = new Vector2(3f, -20f);
		rb.AddForce(force, ForceMode2D.Impulse);
	}

	// Update is called once per frame
	void Update()
    {
  //      pos.x += vx * Time.deltaTime;
  //      vy += 0.5f * Time.deltaTime;
		//pos.y += vy * Time.deltaTime ;
  //      transform.position = pos;
    }
}
