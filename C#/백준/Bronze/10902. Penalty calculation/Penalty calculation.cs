string input = Console.ReadLine();
int n = int.Parse(input);

int m = 0;
int T = 0;
int S = 0;

for (int i = 1; i <= n; i++)
{
    string[] ingput = Console.ReadLine().Split(' ');
    int t = int.Parse(ingput[0]);
    int s = int.Parse(ingput[1]);
    
    if (S < s)
    {
        m = i;
        T = t;
        S = s;
    }
}

if (S == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(T + (m - 1) * 20);
}