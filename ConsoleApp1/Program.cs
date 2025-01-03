// На массивы

// Поворот
int[] t = new int[5] {1, 2, 3, 4, 5};
int[] e = new int[5];
Console.WriteLine();
int s = Convert.ToInt32(Console.ReadLine());
s = s % t.Length;
Console.WriteLine(" ");
for (int i = 0; i < 5; i++)
{
    e[(i + s) % t.Length] = t[i];
}
foreach (int i in e)
{
    Console.WriteLine(i);
}
// Удаление дубликатов
int[] q = new int[6] {1, 2, 3, 4, 4, 5};
int[] w = new int[];

for (int i = 0; i < 6; i++)
{

}