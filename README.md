# PocketShooting0
Unityの2Dシューティングゲーム試作品

## プレイヤーのゲームオーバー時のエフェクトを追加する(4/12)

### エフェクト用イメージ画像をシーンに配置
![kya](https://user-images.githubusercontent.com/32384416/217694815-942f15a1-4726-423c-9781-b0df0d2157fb.png)

### エフェクト用画像のInspector設定
- Rigidbody2Dコンポーネント追加
- Rigidbody2DのBodyTypeは、Dynamicで使用
- [KyaController.cs](https://github.com/mrgarita/PocketShooting0/blob/player_kya_effect/KyaController.cs)スクリプトを作成しアタッチ
- KyaController.csの追加により[PlayerController.cs](https://github.com/mrgarita/PocketShooting0/blob/player_kya_effect/PlayerController.cs)の一部修正
- [EnemyController.cs](https://github.com/mrgarita/PocketShooting0/blob/player_kya_effect/EnemyController.cs)の一部修正

[次のステップ(5/12)＞＞ 敵2の追加](https://github.com/mrgarita/PocketShooting0/tree/enemy2_add)
