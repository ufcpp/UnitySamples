using System;
using System.Runtime.CompilerServices;
/// <summary>
/// 8バイト固定の固定長配列。
///
/// C# には fixed byte[8] みたいな書き方で固定長バッファーを使える構文があるんだけど、あれは結構使い勝手が悪く。
/// いっそ、<see cref="Unsafe"/> クラスを使った方が速かったり。
///
/// ジェネリックにしたいけど、where T : unmanaged 制約は Unity で使えなかった。
/// unmanaged 制約がないとポインターが使えず。
/// 今回はデモ用と言うことで byte 固定。
/// </summary>
public struct Byte8
{
    byte x1, x2, x3, x4, x5, x6, x7, x8;
    public unsafe Span<byte> AsSpan() => new Span<byte>(Unsafe.AsPointer(ref x1), 8);
    public int Length => 8;
    public byte this[int i]
    {
        get { return AsSpan()[i]; }
        set { var s = AsSpan(); s[i] = value; }
    }
}
