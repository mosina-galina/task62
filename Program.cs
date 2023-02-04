//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int n = 4;
int[,] array = new int [n,n];
NewArray(array);
WriteArray(array);
void NewArray (int[,]array)
{
    int p = 1;
    int m = n;
    int i = 0;
    int j = 0;
    while (p<=n*n)
    {
        array[i, j] = p;
        p=p+1;
            if (i <= j + 1 && i + j < m - 1) j++;
            else if (i < j && i + j >= n - 1) i++; 
            else if (i >= j && i + j > m - 1) j--; 
            else i--;
        
    }  

}
void WriteArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
         Console.WriteLine();
    }
}  