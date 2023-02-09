# PocketShooting0
Unity2Dでシューティングゲームを制作する

## 敵2のを追加する

### 敵2の画像
![teki2](https://user-images.githubusercontent.com/32384416/217724525-867c39e0-cd27-493a-9a11-3528cd8fd1fb.png)

### シーンに配置した敵2のInspector設定
- スクリプト[Enemy2Controller](https://github.com/mrgarita/PocketShooting0/blob/enemy2_add/Enemy2Controller.cs)を作成しアタッチ
- スクリプトアタッチ後、Speed（落下速度 例5）、Vy（加速度 例0.1）をそれぞれ設定
- 敵2の動作確認後、プレハブ化し名前をEnemey2とする

### GameMainオブジェクト
- 敵2の追加にともない、スクリプト[EnemyGenerator](https://github.com/mrgarita/PocketShooting0/blob/enemy2_add/EnemyGenerator.cs)を一部追加
- InspectorのEnemy2PrefabにEnemy2プレハブを設定

[次のステップ(6/12)＞＞ ボスキャラの作成](https://github.com/mrgarita/PocketShooting0/tree/boss_motion)
