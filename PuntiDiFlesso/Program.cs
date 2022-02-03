// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Random rnd = new Random();
int[] a = new int[10];

Console.WriteLine("Il vettore è:");
for (int i = 0; i < a.Length; i++)
{
    a[i] = rnd.Next(1, 101);
    Console.Write(a[i] + "\t");

}

IList<int> maximums = new List<int>();
if (a[0] > a[1]) //estremo sinistro
{
    maximums.Add(a[0]);
}
if (a[a.Length - 1] > a[a.Length - 2]) //estremo destro
{
    maximums.Add(a[a.Length - 1]);
}
for (int j = 1; j < a.Length - 1; j++)
{
    if (a[j] > a[j - 1] && a[j] > a[j + 1])
    {
        maximums.Add(a[j]);
    }
}
Console.WriteLine("\nI massimi sono:");
foreach (var item in maximums)
{
    Console.WriteLine(item);
}

