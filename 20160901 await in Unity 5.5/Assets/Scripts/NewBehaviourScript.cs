using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        X();

        XAsync();

        Action a = null;
        foreach (var x in new[] { 1, 2, 3, 4, 5, })
        {
            a += () => Debug.Log(x);
        }


        a();

        Debug.Log(Xx);
    }

    int Xx => 10;

    static void X([CallerMemberName] string caller = null)
    {
        Debug.Log("X " + caller);
    }

    static async Task XAsync()
    {
        for (int i = 0; i < 10; i++)
        {
            var j = await ClassLibrary1.Class1.EchoAsync(i);
            Debug.Log("XAsync " + j);
        }
    }
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    public sealed class CallerMemberNameAttribute : Attribute
    {
        public CallerMemberNameAttribute()
        {
        }
    }
}
