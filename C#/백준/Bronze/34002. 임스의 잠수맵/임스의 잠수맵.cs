int[] expRates = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int A = expRates[0], B = expRates[1], C = expRates[2];

int[] tickets = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int S = tickets[0], V = tickets[1];

int L = int.Parse(Console.ReadLine());

long needXp = (250 - L) * 100;
long totalMins = 0;

for (int i = 0; i < V && needXp > 0; i++)
{
    for (int min = 0; min < 30 && needXp > 0; min++)
    {
        needXp -= C;
        totalMins++;
    }
}

for (int i = 0; i < S && needXp > 0; i++)
{
    for (int min = 0; min < 30 && needXp > 0; min++)
    {
        needXp -= B;
        totalMins++;
    }
}

if (needXp > 0)
{
    totalMins += (needXp + A - 1) / A;
}

Console.WriteLine(totalMins);