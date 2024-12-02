using Lib;

string[] data = File.ReadAllLines("inputDay1.txt");


AlgoBuilder builder = new AlgoBuilder( 1, false);
IAlgo algo = builder.Build();

if (algo == null)
{
    Console.WriteLine("Algo not found");
    return;
}

string sum = algo.Solve(data, true);
Console.WriteLine(sum);