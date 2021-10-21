# PocketShooting0
Unityの2Dシューティングゲーム試作品
* ボスの動きを作る
- シーンにボスのスプライト配置(boss)
- bossの初期位置を画面上方枠外にしておく
- bossにCollider2D追加
- tagをBossとする
- bossにスクリプトBossController.cs追加

* ボスの作成に伴い以下のファイルを修正
- BulletController.cs（ボスとの当たり判定部分）
