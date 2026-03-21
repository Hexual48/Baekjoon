int n = int.Parse(Console.ReadLine());
string s = Console.ReadLine();
int sum = 0;
for (int i = 0; i < n; i++)
{
    string oneDigitString = s[i].ToString();
    int num = int.Parse(oneDigitString);
    sum += num;
}
Console.Write(sum);