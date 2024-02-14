using DiveToCSharp;

int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

var array = DoubleArraySort.SortDoubleArray(a);

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] +" ");
    }
    Console.WriteLine();
}