# PocketShooting0
Unity2Dでシューティングゲームを制作する

## 敵2を追加する(5/12)
敵2は上から回転しながら落ちてきて、倒すまで上下に行ったり来たりを繰り返します

### 敵2の画像
![teki2](https://user-images.githubusercontent.com/32384416/217724525-867c39e0-cd27-493a-9a11-3528cd8fd1fb.png)

### 敵2の作成
- シーンに敵2の画像を配置
- スクリプト[Enemy2Controller](https://github.com/mrgarita/PocketShooting0/blob/enemy2_add/Enemy2Controller.cs)を作成しアタッチ
- スクリプトアタッチ後、InspectorのSpeed（落下速度 例5）、Vy（加速度 例0.1）をそれぞれ設定
- 敵2の動作確認後、プレハブ化し名前を**Enemey2**とする

### GameMainオブジェクト
- 敵2の追加にともない、スクリプト[EnemyGenerator](https://github.com/mrgarita/PocketShooting0/blob/enemy2_add/EnemyGenerator.cs)を一部追加
- Inspectorの**Enemy2Prefab**に**Enemy2プレハブ**を設定

[次のステップ(6/12)＞＞ ボスキャラの作成](https://github.com/mrgarita/PocketShooting0/tree/boss_motion)
