int a = int.Parse(Console.ReadLine());
int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
Array.Sort(n);
Console.Write(n[0] + " " + n[n.Length - 1]);