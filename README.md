# PocketShooting0
Unityの2Dシューティングゲーム試作品
## ボスの動きを作る
- シーンにボスのスプライト配置(boss)
- bossの初期位置を**画面上方枠外**にしておく
- bossに**Collider2D**追加（Is Triggerにチェック）
- tagを**Boss**とする
- bossにスクリプト**BossController.cs**アタッチ

## BossControllerスクリプトアタッチ後のInspectorウインドウ設定
- Boss Explotion Effect: ボスが攻撃されたときの爆発プレハブを設定
- Boss Se: ボスが攻撃されたときの効果音を設定
- Speed: 実数、ボスの移動速度を設定
- Boss Hp:　整数、ボスの体力を設定（何回攻撃されたら倒れるか）
- Boss Bullet Normal: 未使用
- Boss Bullet Special: 未使用

## ボスの作成に伴い以下のファイルを修正
- **BulletController.cs**（ボスとの当たり判定部分）

**※とりあえずこの段階ではボスの攻撃部分が完成していないので、シーンに作成したbossのプレハブ化はしない**
