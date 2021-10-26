# PocketShooting0
Unityの2Dシューティングゲーム試作品
## ボスの弾幕攻撃を追加する
### 弾幕用の画像
イメージ
![boss_tama](https://user-images.githubusercontent.com/32384416/138202419-e1cbc91d-13dd-4524-8ef2-44bf684581d8.png)

### 弾幕用画像をシーンに配置してプレハブ化する
- 弾幕用画像をシーンに配置
- 配置した画像に[BossBulletController.cs](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet1/BossBulletController.cs)をアタッチ
- アタッチ後、Inspectorウインドウの**Speed項目**に弾の速度を適当に設定（実数）
- 当たり判定用に**Circle Collider 2D**コンポーネントを追加
- tagを**EnemyBullet**とする
- プレハブ化して**BossBullet**に名前変更

### BossControllerスクリプトに弾幕発射部分を加える
- [BossController.cs](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet1/BossController.cs)に修正
- 修正後、シーン上のボスを選択しInspectorウインドウのBoss Bullet Normalにプレハブ**BossBullet**を設定

### ボスの弾幕攻撃修正に伴い以下スクリプトを修正
- [PlayerController.cs](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet1/PlayerController.cs)　**ボスの弾幕との当たり判定部分**

### その他修正スクリプト
- [KyaController.cs](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet1/KyaController.cs)　**下に消えてもオブジェクトが存在していたので修正**
