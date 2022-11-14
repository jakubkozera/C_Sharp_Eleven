// See https://aka.ms/new-console-template for more information
using System.Numerics;

int[] ints = new int[] { 1, 3, 4 };

var sum = AddAllInts(ints);

int AddAllInts(int[] values)
{
    int result = 0;

    foreach (var value in values)
        result += value;
    return result;
}

T AddAll<T>(T[] values) where T : INumber<T>
{
    T result = T.AdditiveIdentity;

    foreach (var value in values)
        result += value;
    return result;
}