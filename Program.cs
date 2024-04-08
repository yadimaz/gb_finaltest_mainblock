using System.Globalization;

Console.Clear();
string[] mas = { "Hello", "2", "world" };
int len = 0;
foreach (string item in mas)
{
    if (item.Length < 4) len++;
}

string[] finalmas = new string[len];
for (int i = 0, j = 0; i < mas.Length; i++)
{
    if (mas[i].Length < 4)
    {
        finalmas[j] = mas[i];
        j++;
    }
}
Console.Write($"[{string.Join(", ", mas)}] > [{string.Join(", ", finalmas)}]");