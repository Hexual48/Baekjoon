long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
long n = a[0];
long k = a[1];
long x = a[2];
int[] b = {0, 1, 2, 2, 3, 3, 3, 3, 4, 4, 4};
long sum = 0;
long ans = (n+1-b[x]) - 3 * (k-1);
if (x == 4 || x == 8 || x == 9)
{
    ans++;
}
sum += ans;
Console.WriteLine(sum);