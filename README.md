# PocketShooting0
- Unityの2Dシューティングゲーム試作品
- **一定の敵を倒すとボスが出現する**

## ゲームの状態を管理する
- スクリプト[GameController]()を作成し、**GameMain**にアタッチ

## ボスの出現を制御する
- スクリプト[UIController]()を修正（外部から得点を取得できるメソッド追加）
- シーン上のボスを**プレハブ化**してプレハブ名を**Boss**に変更
- ボスの出現を制御するためスクリプト[EnemyGenerator]()を修正
- EnemyGenerator修正後、シーン上の**GameMain**を選択しInspectorの**Boss Prefab**にボスのプレハブを設定

## ここまでのイメージ
