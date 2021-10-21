# PocketShooting0
Unityの2Dシューティングゲーム試作品
## ボスの弾幕攻撃を追加する
### 弾幕用の画像
イメージ
![boss_tama](https://user-images.githubusercontent.com/32384416/138202419-e1cbc91d-13dd-4524-8ef2-44bf684581d8.png)

### 弾幕用攻撃弾をシーンに作成してプレハブ化
- 弾幕用画像をシーンに配置
- 配置した画像に[BossBulletController.cs]()をアタッチ
- アタッチ後、Inspectorウインドウの**Speed項目**に弾の速度を適当に設定（実数）
- プレハブ化して**BossBullet**に名前変更

### BossControllerスクリプトに弾幕発射部分を加える
- [BossController.cs]()に修正
- 修正後、シーン上のボスを選択しInspectorウインドウのBoss Bullet Normalに作ったBossBulletを設定

