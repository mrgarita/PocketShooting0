# PocketShooting0
Unity2Dでシューティングゲームを制作する

## プレイヤーのゲームオーバー時のエフェクトを追加する(4/12)

### エフェクト用画像
白い文字の透過画像なので見えませんがこの下に画像があります
![kya](https://user-images.githubusercontent.com/32384416/217694815-942f15a1-4726-423c-9781-b0df0d2157fb.png)

### ゲームオーバー時のエフェクト作成
- エフェクト用画像をシーンに配置
- Rigidbody2Dコンポーネント追加
- Rigidbody2DのBodyTypeは、Dynamicで使用
- [KyaController](https://github.com/mrgarita/PocketShooting0/blob/player_kya_effect/KyaController.cs)スクリプトを作成しアタッチ
- プレハブ化し、プレハブ名を**Kya**とする

### スクリプト修正
- KyaControllerの追加により[PlayerController](https://github.com/mrgarita/PocketShooting0/blob/player_kya_effect/PlayerController.cs)の一部修正
- シーン上のPlayerのInspectorにあるKya PrefabにプレハブKyaを設定
- [EnemyController](https://github.com/mrgarita/PocketShooting0/blob/player_kya_effect/EnemyController.cs)の一部修正

[次のステップ(5/12)＞＞ 敵2の追加](https://github.com/mrgarita/PocketShooting0/tree/enemy2_add)
