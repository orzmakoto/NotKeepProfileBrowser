# ユーザプロファイルを保存しないブラウザー

![image](https://user-images.githubusercontent.com/12761202/198816096-ea8463ab-3a69-40dd-a8e4-428e1d73120a.png)

## 特徴
- このブラウザは、タブUIを実装したブラウザでありながらタブ間でユーザプロファイルを共有しません
- タブでブラウザを開くとその都度、新しいユーザプロファイルが作成されます
- 永続的なプロファイルを必要とする場合には、任意の名前をつけて保存可能です
- ブラウザコンポーネントには、Microsoftから提供されいるWebView2を採用し高速で安定した動作を実現
- Webアプリケーションの検証などで複数のユーザを同時にログインするケースに適しています

## 主な機能

1. タブごとに異なるユーザプロファイルを作成し終了時に廃棄
2. タブごとに背景色の変更
3. 任意の名前付きのユーザプロファイルを作成
4. 自動保存可能されるメモ機能

## 動作環境

- OS
  - Windows10,11
- ランタイム
  - .NET Framework 4.7.2～
  - [WebView2](https://developer.microsoft.com/ja-jp/microsoft-edge/webview2/#download-section)


## 利用開始方法

1. ビルド版のダウンロード

[NKPB_1.1.zip](https://github.com/orzmakoto/NotKeepProfileBrowser/raw/master/Binary/NKPB_1.1.zip)からZipファイルをダウンロード

2. ダウンロードしたZipファイルを展開

![image](https://user-images.githubusercontent.com/12761202/198855145-cd9d511f-7634-499a-8449-58f9f3687e2f.png)

3. 展開したフォルダに含まれる**NotKeepProfileBrowser.exe**を実行

![image](https://user-images.githubusercontent.com/12761202/198854977-c455e9f1-4cd3-481a-adeb-fa5e619682fa.png)

