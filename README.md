# PocketShooting0
Unity2Dでシューティングゲームを制作する

## ボスの攻撃2を作成する
ボスの攻撃2は、避けるのが難しい**幅の広い高速ショット**です

## ボスの攻撃2画像
![boss_shot](https://user-images.githubusercontent.com/32384416/139364806-b725159b-ce5b-4aed-9b3d-ba4e12f1d727.png)

## 幅の広い高速ショットの作成
- 攻撃2用の画像をシーンに配置
- **Collider 2D**コンポーネントを追加（Is Triggerにチェック）
- [BossSpecialBulletController](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet2/BossSpecialBulletController.cs)スクリプトを作成しアタッチ
- アタッチ後、Inspectorウインドウの**Speed**（発射速度,10くらいが適当）と**Se**（発射時の効果音）を設定
- Tagを**EnemyBullet**とする（ボスの弾幕と同じ）
- プレハブ化する（プレハブ名：**BossSpecialBullet**）

## ボスにアタッチ済みのスクリプト修正
- [BossController](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet2/BossController.cs)スクリプトを強化攻撃できるように修正
- 修正後ボスのInspectorウインドウの**Boss Bullet Special**項目に**BossSpecialBullet**プレハブを設定

[次のステップ(9/12)＞＞ 一定のスコアをこえるとボスが登場する](https://github.com/mrgarita/PocketShooting0/tree/boss_appearance)
