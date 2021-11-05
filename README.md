# PocketShooting0
- Unityの2Dシューティングゲーム試作品
- **ゲームクリアとゲームオーバーのメッセージを表示する**

## 寂しいのでゲーム中のBGMを追加
- シーン上の**GameMain**に**Audio Source**コンポーネントを追加
- Inspectorから**Audio Clip**に好きなBGM用音源を設定（Play On AwakeとLoopにチェック）

## プレイヤーがやられたときゲームオーバーとする
- スクリプト[PlayerController](https://github.com/mrgarita/PocketShooting0/blob/game_message/PlayerController.cs)を修正（GameMainに設定したGameControllerスクリプトとゲームの状態変数がかぶるため消去しGameControllerを参照するように変更、その他プレイヤーがやられたときの効果音再生を追加）
- スクリプト修正後、Inspectorから**Game Over Se**にやられた時の効果音を設定

## ボスを倒したときゲームクリアとする
- スクリプト[BossController](https://github.com/mrgarita/PocketShooting0/blob/game_message/BossController.cs)を修正

## メッセージ表示部分を追加
- シーンに**UI　＞　Text** を追加し名前を**Message**とする（シーン中央に設定）
- スクリプト[UIController](https://github.com/mrgarita/PocketShooting0/blob/game_message/UIController.cs)を修正（Messageにゲームクリア・ゲームオーバーの表示をする）
- UIController修正後、シーン上の**Canvas**をクリック、Inspectorウインドウの**UI Controller**部分の**Score**と**Message**にそれぞれシーン上の*Score*と*Messsage*を設定する

## ここまでのイメージ
### プレイヤーがやられたとき（ゲームオーバー）
![pocketshooting_gameover](https://user-images.githubusercontent.com/32384416/140453942-9b44c8e1-cc93-42dc-a403-31cde1a55b53.gif)

### ボスを倒したとき（ゲームクリア）
![pocketshooting_gameclear](https://user-images.githubusercontent.com/32384416/140453924-2829405b-b78b-446c-85de-666744b41428.gif)
