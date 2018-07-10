# Unity で Span とかを使う

Unity 2018<sup>※</sup> では .NET 4.x / .NET Standard 2.0 なコードが結構ちゃんと動くというのを示すデモ。

<sup>※</sup> 確認を取っていないだけで、たぶん Unity 2017 でも行けそう。
Unity 2017 は初期に結構 .NET 4.x がらみのバグがあったので、初期のものだとダメかも。

以下の、割かし最近出たばかりのライブラリを参照して、実機で動くのを確認。

- [System.Runtime.CompilerServices.Unsafe](https://www.nuget.org/packages/System.Runtime.CompilerServices.Unsafe/)
- [System.Memory](https://www.nuget.org/packages/System.Memory/)
- [System.Buffers](https://www.nuget.org/packages/System.Buffers/)

## Configuration

- Runtime Version は 4.x 必須
- Scripting Backend は Mono でも IL2CPP でも大丈夫
- Api Comatibility Level は .NET 4.x でも .NET Standard 2.0 でも大丈夫
- C# コンパイラーはデフォルトのもの(Mono の C# 6.0 コンパイラー)で OK

## パッケージの参照

- nuget.org から取ってきたパッケージから、中身の dll をコピーして持ってきてる
- netstandard2.0 向けの dll をコピー
