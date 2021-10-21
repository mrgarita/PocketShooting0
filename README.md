# PocketShooting0
Unityの2Dシューティングゲーム試作品
## ボスの動きを作る
- シーンにボスのスプライト配置(boss)
- bossの初期位置を**画面上方枠外**にしておく
- bossに**Collider2D**追加
- tagを**Boss**とする
- bossにスクリプト**BossController.cs**追加

## ボスの作成に伴い以下のファイルを修正
- **BulletController.cs**（ボスとの当たり判定部分）
