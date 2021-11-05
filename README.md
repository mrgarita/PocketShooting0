# PocketShooting0
- Unityの2Dシューティングゲーム試作品
- **一定の敵を倒すとボスが出現する**

## ゲームの状態を管理する
- スクリプト[GameController](https://github.com/mrgarita/PocketShooting0/blob/boss_appearance/GameController.cs)を作成し、**GameMain**にアタッチ

## ボスの出現を制御する
- スクリプト[UIController](https://github.com/mrgarita/PocketShooting0/blob/boss_appearance/UIController.cs)を修正（外部から得点を取得できるメソッド追加）
- シーン上のボスを**プレハブ化**してプレハブ名を**Boss**に変更
- ボスの出現を制御するためスクリプト[EnemyGenerator](https://github.com/mrgarita/PocketShooting0/blob/boss_appearance/EnemyGenerator.cs)を修正
- EnemyGenerator修正後、シーン上の**GameMain**を選択しInspectorの**Boss Prefab**にボスのプレハブを設定

## ここまでのイメージ
![pocketshooting_boss_appearance](https://user-images.githubusercontent.com/32384416/140442205-e40f56c1-27ab-42b4-be0a-2d09a942de44.gif)
