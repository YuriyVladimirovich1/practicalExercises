Console.WriteLine("Введите сколько строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбцов");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
double[,] mass = new double[m, n];
void FillDoubleMassive(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(1, 10) + Math.Round(new Random().NextDouble(), 1);
            Console.Write(massive[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintDoubleMassive(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {

            Console.Write(massive[i, j] + " ");
        }
        Console.WriteLine();
    }

}
void Change4etniy(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i += 2)
    {
        for (int j = 0; j < massive.GetLength(1); j += 2)
        {
            massive[i, j] = Math.Round(Math.Pow(massive[i, j], 2), 2);
        }

    }
    Console.WriteLine();
}
void MainDiagonal(double[,] massive)
{
    double summ = 0;
    for (int i = 0; i < Math.Min(massive.GetLength(0), massive.GetLength(1)); i++)
    {
        summ += mass[i, i];
    }
    Console.WriteLine();
    Console.WriteLine(summ);
    Console.WriteLine();
}

FillDoubleMassive(mass);
MainDiagonal(mass);
Change4etniy(mass);
PrintDoubleMassive(mass);