using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
        
  }

  // Update is called once per frame
  void Update()
  {
    // ジョイパッドのBボタン　または　Enterキーが押されたらゲーム開始
    if (Input.GetButtonDown("Fire2") || Input.GetKeyDown(KeyCode.Return))
    {
      SceneManager.LoadScene("GameScene");
    }
  }
}
