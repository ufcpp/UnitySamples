using System;
using System.Buffers;
/// <summary>
/// <see cref="ArrayPool{T}"/>から借りてきて、<see cref="Dispose"/>で返却するためのラッパー。
/// </summary>
public struct PooledArray<T> : IDisposable
{
    public T[] Array { get; }
    private ArrayPool<T> _pool;
    public PooledArray(int minimumLength) : this(minimumLength, ArrayPool<T>.Shared) { }
    public PooledArray(int minimumLength, ArrayPool<T> pool)
    {
        Array = pool.Rent(minimumLength);
        _pool = pool;
    }
    public T this[int i]
    {
        get { return Array[i]; }
        set { Array[i] = value; }
    }
    public void Dispose() => _pool?.Return(Array);
}