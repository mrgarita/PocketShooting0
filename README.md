# PocketShooting0
- Unityの2Dシューティングゲーム試作品
- **ゲームクリアとゲームオーバーのメッセージを表示する**

## 寂しいのでゲーム中のBGMを追加
- シーン上のGameMainにAudio Sourceコンポーネントを追加
- InspectorからAudio Clipに好きなBGM用音源を設定（Play On AwakeとLoopにチェック）

## プレイヤーがやられたときゲームオーバーとする
- スクリプト[PlayerController]()を修正（GameMainに設定したGameControllerスクリプトとゲームの状態変数がかぶるので消去しGameControllerを参照するように変更、その他プレイヤーがやられたときの効果音再生を追加）
）
- スクリプト修正後、InspectorからGame Over Seにやられた時の効果音を設定

## ボスを倒したときゲームクリアとする
- スクリプト[BossController]()を修正

## メッセージ表示部分を追加
- シーンにUI　＞　Text　追加し名前をMessageとする（配置は中央に設定）
- スクリプト[UIController]()を修正（Messageにゲームクリア・ゲームオーバーの表示をする）
- UIController修正後、Inspectorウインドウの

## ここまでのイメージ
![pocketshooting_boss_appearance](https://user-images.githubusercontent.com/32384416/140442205-e40f56c1-27ab-42b4-be0a-2d09a942de44.gif)
