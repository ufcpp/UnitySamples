using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using static System.Math;

/// <summary>
/// mcs.rsp に -langversion:6 オプションを書いているのでコンパイル自体は通る。
///
/// <see cref="Task"/>クラスの .NET 3.5 向け実装を持っているので、await も普通に使える。
/// それなりの規模のゲームで使って、iOS/Android ともに問題なく動いてる。
///
/// 
/// </summary>
public class Csharp6Global : MonoBehaviour
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

        Debug.Log("C# 6 in global namespace");
    }
}
