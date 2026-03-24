int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int h = n[0], m = n[1];
DateTime time = new DateTime(1, 1, 2, h, m, 0);
DateTime sum = time.AddMinutes(-45);
Console.WriteLine(sum.Hour+" "+sum.Minute);