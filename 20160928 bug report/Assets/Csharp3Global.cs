using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 普通に Unity で使える C# ３ コード。
/// 全部のクラスを global に作るの止めろよ。
/// </summary>
public class Csharp3Global : MonoBehaviour
{
    int Value { get { return 10; } }

    void Start()
    {
        var dic = new Dictionary<string, int>();
        dic["one"] = 1;
        dic["two"] = 2;
        dic["three"] = 3;

        Task.Delay(1000).ContinueWith(_ =>
        {
            var sum = 0.0;
            foreach (var item in dic)
            {
                sum += Math.Pow(item.Value, Value);
            }

            Debug.Log("C# 3 in global namespace");
        });
    }
}
