

using Arrays.Logic;

try
{
	Console.WriteLine("Hello Vector!");

	Vector vector = new(50);
    vector.Fill(1, 100);
    //vector.Add(10);
    //vector.Add(20);
    //vector.Add(30);
    //vector.Insert(7, 0);
    //for (int i = 0; i < vector.N; i++)
    //{
    //	vector.Add(i * 3);
    //}
    Console.WriteLine(vector);
	//vector.Remove(0);
	Console.WriteLine("------------------------");
    var odds = vector.GetOdds();
	Console.WriteLine(odds);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//vector.Fill(1, 100);

//Console.WriteLine("Unsorted Array!");
//Console.WriteLine(vector);

//vector.Sort(true);
//Console.WriteLine("Ascending Sorted Array!");
//Console.WriteLine(vector);

//vector.Sort(false);
//Console.WriteLine("Descending Sorted Array!");
//Console.WriteLine(vector);