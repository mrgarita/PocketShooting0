# PocketShooting0
Unityの2Dシューティングゲーム試作品

## ボスの強化攻撃（よけるのが難しい速いショット）を追加する

## 強化攻撃用画像イメージ
![boss_shot](https://user-images.githubusercontent.com/32384416/139364806-b725159b-ce5b-4aed-9b3d-ba4e12f1d727.png)

## 強化攻撃用のプレハブを作成
- 強化攻撃用画像をシーンに配置
- **Collider 2D**コンポーネントを追加（Is Triggerにチェック）
- [BossSpecialBulletController](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet2/BossSpecialBulletController.cs)スクリプトを作成しアタッチ
- アタッチ後、Inspectorウインドウの**Speed**（発射速度,10くらいが適当）と**Se**（発射時の効果音）を設定
- プレハブ化する（プレハブ名：**BossSpecialBullet**）

## ボスにアタッチ済みのスクリプト修正
- [BossController](https://github.com/mrgarita/PocketShooting0/blob/boss_bullet2/BossController.cs)スクリプトを強化攻撃できるように修正
- 修正後ボスのInspectorウインドウの**Boss Bullet Special**項目に**BossSpecialBullet**プレハブを設定
