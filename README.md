# PocketShooting0
- Unityの2Dシューティングゲーム試作品
- **タイトル画面からゲーム画面への遷移**

## タイトル画面の作成
イメージ
<img width="229" alt="pocketshooting_title" src="https://user-images.githubusercontent.com/32384416/141222759-c7a854e2-e49d-474d-83fd-9ce9f7ba17fe.PNG">

### シーンファイル作成
- File > New Scene からシーンファイルを新規作成
- File > Save As...　でファイル名を**TitleScene**としてScenesフォルダに保存

### タイトル画面の背景色
Main Cameraの設定変更
- Cameraコンポーネントの*Clear Flags*を**Solid Color**に変更
- **Background**で背景色を設定

### タイトル文字
UI ＞　Text　追加し、Canvasの*Canvas Scaler*項目を以下のように設定
- *UI Scale Mode*を**Scale With Screen Size**にする
- *Reference Resolution*の**X**を**720**, **Y**を**1280**とする
- *Screen Match Mode*を**Expand**に設定
<img width="296" alt="canvas_scaler" src="https://user-images.githubusercontent.com/32384416/141222525-b7c3a939-7098-4fcc-a347-f7bb1a1cbc86.PNG">

### 追加したCanvasのTextに以下の設定をする
画面の中央にタイトル文字が表示されるように設定

#### Rect Transform
- *center*　*middle*で中央に配置
- *Width*は**720**, *Height*は**300**（余裕をもって大きめに設定しておく）

#### Textコンポーネント
- *Text*の文字列にタイトル文字を入力　例）Pocket Shooting

#### Character
- *Font*は**ThaleahFat**（なんでも良い）
- *Font Size*は**80**

#### Paragrash
- *Alignment*	上下左右とも中央
- Color（お好みの色を設定）
		
### タイトル画面用のスクリプト
- スクリプト[TitleController](https://github.com/mrgarita/PocketShooting0/blob/title_to_game/TitleController.cs)を作成し、**Canvas**にアタッチ

### タイトルシーンをプロジェクトに追加
- **File > Build Settings...** を開き、*Scene In Build*項目に**TitleScene**、**GameScene**の順に追加しておく
<img width="475" alt="build_settings" src="https://user-images.githubusercontent.com/32384416/141222561-ac99e57d-10c9-4ffd-8964-2b692c1812d6.PNG">

## ここまでの状態を実行確認
- TitleSceneを開いた状態で、プロジェクトを実行
- ゲームパッドの**Bボタン**または**Enterキー**でゲーム画面に遷移すればOK
![pocketshooting_title2game](https://user-images.githubusercontent.com/32384416/141222036-01ec9fd2-a5bb-477e-82e3-52af43ed114b.gif)
