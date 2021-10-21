# PocketShooting0
Unityの2Dシューティングゲーム試作品
## ボスの動きを作る
- シーンにボスのスプライト配置(boss)
- bossの初期位置を**画面上方枠外**にしておく
- bossに**Collider2D**追加（Is Triggerにチェック）
- tagを**Boss**とする
- bossにスクリプト**BossController.cs**追加

## ボスの作成に伴い以下のファイルを修正
- **BulletController.cs**（ボスとの当たり判定部分）

**※とりあえずこの段階ではボスの攻撃部分が完成していないので、シーンに作成したbossのプレハブ化はしない**
