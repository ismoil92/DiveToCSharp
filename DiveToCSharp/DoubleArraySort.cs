namespace DiveToCSharp;

public class DoubleArraySort
{
    public static int[,] SortDoubleArray(int[,] array)
    {
        int y = array.GetLength(0);
        int x = array.GetLength(1);
        int[] sort = new int[x * y];
        int counter = 0;
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                sort[counter] = array[i, j];
                counter++;
            }
        }
        Array.Sort(sort);

        counter = 0;
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                array[i, j] = sort[counter];
                counter++;
            }
        }
        return array;
    }
}