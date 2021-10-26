# PocketShooting0
Unityの2Dシューティングゲーム試作品

## シーンにボスのスプライト配置(boss)
イメージ画像
![boss](https://user-images.githubusercontent.com/32384416/138200097-7497d9c3-970e-45d5-a286-0b0b2848a470.png)

## ボスの動きを作る
- bossの初期位置を**画面上方枠外**にしておく
- bossに**Collider2D**追加（Is Triggerにチェック）当たり判定用
- bossに**Rigidbody2D**追加（BodyT TypeはKinematicでOK）当たり判定用
- tagを**Boss**とする　当たり判定用
- bossにスクリプト[BossController.cs](https://github.com/mrgarita/PocketShooting0/blob/boss_motion/BossController.cs)アタッチ

## BossControllerスクリプトアタッチ後のInspectorウインドウ設定
- Boss Explotion Effect: ボスが攻撃されたときの爆発プレハブを設定
- Boss Se: ボスが攻撃されたときの効果音を設定
- Speed: 実数、ボスの移動速度を設定
- Boss Hp:　整数、ボスの体力を設定（何回攻撃されたら倒れるか）
- Boss Bullet Normal: 未使用
- Boss Bullet Special: 未使用

## ボスの作成に伴い以下のファイルを修正
- [BulletController.cs](https://github.com/mrgarita/PocketShooting0/blob/boss_motion/BulletController.cs)（ボスとの当たり判定部分）

**※とりあえずこの段階ではボスの攻撃部分が完成していないので、シーンに作成したbossのプレハブ化はしない**
