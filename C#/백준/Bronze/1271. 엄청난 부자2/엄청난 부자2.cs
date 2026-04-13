using System.Numerics;

BigInteger[] array = Array.ConvertAll(Console.ReadLine().Split(" "), BigInteger.Parse);
Console.WriteLine(array[0] / array[1]);
Console.WriteLine(array[0] % array[1]);