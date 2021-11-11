# PocketShooting0
- Unityの2Dシューティングゲーム試作品
- **ゲーム画面からタイトル画面への遷移**
- まあ、これで一応*ゲームっぽく*なったのではないでしょうか？

## 完成イメージ
- タイトル画面からはゲームパッドの**Bボタン**又は**Enterキー**でゲーム画面に遷移します

![pocketshooting_game2title](https://user-images.githubusercontent.com/32384416/141254498-03fdeb2f-5809-47a2-9e97-8d52201a51e3.gif)


## ゲームオーバー/ゲームクリアでタイトル画面に戻るため2つのスクリプトを修正する
- [GameController](https://github.com/mrgarita/PocketShooting0/blob/game_to_title/GameController.cs)スクリプトの修正

  - 修正内容
    - using UnityEngine.SceneManagement;追加
    - ゲームの状態にTITLEを追加
    - ゲーム終了メソッド（ExitGame）追加
    - Updateメソッドに遷移処理を追加

- [PlayerController](https://github.com/mrgarita/PocketShooting0/blob/game_to_title/PlayerController.cs)スクリプトの修正

  - 修正内容
    - GameOverメソッド内に1行追加
