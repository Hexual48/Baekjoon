double[] array = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
double s = array[0];
double p = array[1];
int answer = 0;
answer = -1;

if (Math.Abs(s - p) < 1e-12) 
{
    Console.Write(1);
}
else 
{
    for (int n = 2; n <= (int)s; n++)
    {
        if (n * Math.Log(s / n) >= Math.Log(p) - 1e-12)
        {
            answer = n;
            break;
        }
    }
    Console.Write(answer);
}