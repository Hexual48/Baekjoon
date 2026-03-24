int a = int.Parse(Console.ReadLine()),  b = int.Parse(Console.ReadLine()), c =  int.Parse(Console.ReadLine());
int result = a * b * c;
string s = result.ToString();
int[] array = new int[10];
foreach (char ch in s)
{
    int num = ch - '0';
    array[num]++;
}
for (int i = 0; i <= 9; i++) {
    Console.WriteLine(array[i]);
}