using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace MyNamespace
{
    /// <summary>
    /// <see cref="Csharp3Global"/>と中身は全く同じコード。名前空間違い。
    ///
    /// いつかのバージョンからか、global 名前空間でなくても GameObject にさして、Inspector 上で設定ができるようになって、「やっと Unity でもまともな C# コードが書けるようになった」と喜んだものでした。
    /// </summary>
    public class Csharp3Namespace : MonoBehaviour
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

                Debug.Log("C# 3 in MyNamespace namespace");
            });
        }
    }
}
