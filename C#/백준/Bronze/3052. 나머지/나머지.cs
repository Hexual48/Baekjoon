bool[] checklist = new bool[42];
int count = 0;
for (int i = 0; i < 10; i++)
{
    checklist[int.Parse(Console.ReadLine())%42] = true;
}
for (int i = 0; i < checklist.Length; i++)
{
    if (checklist[i] == true)
    {
        count++;
    }
}
Console.Write(count);