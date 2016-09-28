using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using static System.Math;

namespace MyNamespace
{
    /// <summary>
    /// <see cref="Csharp6Global"/>と中身は全く同じコード。名前空間違い。
    ///
    /// <see cref="Csharp6Global"/>(C# 6 だけど global)も大丈夫。
    /// <see cref="Csharp3Namespace"/>(C# 3 で名前空間付き)も大丈夫。
    /// なのにこのクラス(C# 6 で名前空間付き)は GameObject にさせず、Inspector 上に出せない。
    /// なんか Unity が退化してる。
    ///
    /// コンパイル自体は普通にできてるし、GameObject にさえ刺さなければこのクラスも普通に使える。
    /// </summary>
    public class Csharp6Namespace : MonoBehaviour
    {
        int Value => 10;

        async void Start()
        {
            var dic = new Dictionary<string, int>();
            dic["one"] = 1;
            dic["two"] = 2;
            dic["three"] = 3;

            await Task.Delay(1000);

            var sum = 0.0;
            foreach (var item in dic)
            {
                sum += Pow(item.Value, Value);
            }

            Debug.Log("C# 6 in MyNamespace namespace");
        }
    }
}
