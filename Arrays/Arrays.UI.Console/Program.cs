

using Arrays.Logic;

Console.WriteLine("Hello Vector!");

Vector vector = new(10);
vector.Fill(1, 100);

Console.WriteLine("Unsorted Array!");
Console.WriteLine(vector);

vector.Sort(true);
Console.WriteLine("Sorted Array!");
Console.WriteLine(vector);
