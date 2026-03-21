int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < n[1])
    {
        Console.Write(array[i]+" ");
    }
}