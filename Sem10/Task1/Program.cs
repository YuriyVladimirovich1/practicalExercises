
/* Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт 
первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
3 и 4, N = 5 -> 3 4 7 11 18 
6 и 10, N = 4 -> 6 10 16 26  
 */ 
 
Console.Clear(); 
int SumPreviosTwo(int numberStart, int numberSecond, int number) 
{ 
    if (number == 1) return numberStart; 
 
    if (number == 2) return numberSecond; 
 
    return SumPreviosTwo(numberStart, numberSecond, number - 1) + SumPreviosTwo(numberStart, numberSecond, number - 2); 
} 
 
 
Console.WriteLine("Введите numberStart"); 
int numberStart = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите numberFinish"); 
int numberSecond = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите N"); 
int number = int.Parse(Console.ReadLine()); 
Console.WriteLine(); 
 
for (int i = 1; i <= number; i++) 
{ 
Console.Write(SumPreviosTwo(numberStart, numberSecond, i) + " ");     
}