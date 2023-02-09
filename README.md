# PocketShooting0
Unity2Dでシューティングゲームを制作する

## ボスの攻撃1(7/12)
ボスの攻撃には2種類あり、攻撃1は弾幕攻撃です

### 弾幕用の画像
イメージ
![boss_tama](https://user-images.githubusercontent.com/32384416/138202419-e1cbc91d-13dd-4524-8ef2-44bf684581d8.png)

### 弾幕攻撃の作成
- 弾幕用画像をシーンに配置
- 配置した画像に[BossBulletController](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet1/BossBulletController.cs)をアタッチ
- アタッチ後、Inspectorウインドウの**Speed項目**に弾の速度を適当に設定（実数）
- 当たり判定用に**Circle Collider 2D**コンポーネントを追加（Is Triggerにチェック）
- tagを**EnemyBullet**とする
- プレハブ化して**BossBullet**に名前変更

### BossControllerスクリプトに弾幕発射部分を加える
- [BossController](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet1/BossController.cs)に修正
- 修正後、シーン上のボスを選択しInspectorウインドウのBoss Bullet Normalにプレハブ**BossBullet**を設定

### ボスの弾幕攻撃修正に伴い以下スクリプトを修正
- [PlayerController](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet1/PlayerController.cs)　**ボスの弾幕との当たり判定部分**

### その他修正スクリプト
- [KyaController](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet1/KyaController.cs)　**下に消えてもオブジェクトが存在していたので修正**

[次のステップ(8/12)＞＞ ボスの攻撃2](https://github.com/mrgarita/PocketShooting0/tree/boss_bullet2)
