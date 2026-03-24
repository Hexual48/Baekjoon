int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    string n = Console.ReadLine();
    int streak = 0;
    int score = 0;
    
    foreach (char c in n)
    {
        if (c == 'O')
        {
            streak++;
            score += streak;
        }

        if (c == 'X')
        {
            streak = 0;
        }
    }
    Console.WriteLine(score);
}