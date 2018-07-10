using System.Buffers;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    InputField _input = null;

    [SerializeField]
    Text _text1 = null;

    [SerializeField]
    Text _text2 = null;

    [SerializeField]
    Text _text3 = null;

    void Start()
    {
        _input.onValueChanged.AddListener(OnTextChanged);
    }

    /// <summary>
    /// <see cref="Byte8"/> は8バイト固定の構造体。
    /// 長さは変えれないけど、ヒープアロケーション起きない。
    /// </summary>
    private static Byte8 A(byte x)
    {
        var a = new Byte8();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = x;
        }
        return a;
    }

    /// <summary>
    /// <see cref="ArrayPool{T}"/> から借り出した配列を返す。
    /// 頻繁に呼んでもヒープ利用量は増えない。
    ///
    /// でも、プール管理自体が結構重いので、本当は今回みたいな「小さいオブジェクトを頻繁に作る」みたいなのには向かない。遅い。
    ///
    /// あと、Dispose (<see cref="ArrayPool{T}.Return(T[], bool)"/> を忘れるとメモリリーク。
    /// </summary>
    private static PooledArray<byte> B(byte x)
    {
        var a = new PooledArray<byte>(8);
        for (int i = 0; i < 8; i++)
        {
            a[i] = x;
        }
        return a;
    }

    /// <summary>
    /// 参考までに。普通の配列で同じことやる。
    ///
    /// .NET の GC って通常は結構速くて。
    /// 特に、これみたいに小さいオブジェクトをすぐに捨てるみたいな状況(いわゆる Gen 0 GC で全部回収される状況)だとものすごい速い。
    /// なので、デスクトップでこのコードを実行すると、ヒープは確保しまくるのに <see cref="A"/>とそん色なく、<see cref="B"/> よりは数倍速い。
    ///
    /// が、まあ、それは .NET Framework とか .NET Core の話で、Unity の GC はちょっと遅いみたい…
    /// なので、<see cref="B"/> を使う意味もあるかも。
    /// </summary>
    private static byte[] C(byte x)
    {
        var a = new byte[8];
        for (int i = 0; i < 8; i++)
        {
            a[i] = x;
        }
        return a;
    }

    private void OnTextChanged(string s)
    {
        byte x;
        if (!byte.TryParse(s, out x)) return;

        var sb = new StringBuilder();

        var a = A(x);
        for (int i = 0; i < a.Length; i++)
        {
            sb.Append(a[i]);
            sb.Append(' ');
        }
        _text1.text = sb.ToString();

        sb.Clear();

        using (var b = B(x))
        {
            for (int i = 0; i < 8; i++)
            {
                sb.Append(b[i]);
                sb.Append(' ');
            }
            _text2.text = sb.ToString();
        }

        var c = C(x);

        sb.Clear();

        for (int i = 0; i < c.Length; i++)
        {
            sb.Append(c[i]);
            sb.Append(' ');
        }
        _text3.text = sb.ToString();
    }
}
