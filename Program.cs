// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Func(int M,int N)
{ 
    if(M==N)
    {
        return M;
    }
    else 
    {
     return M+Func(M+1,N);
    }
    
}
Console.WriteLine($"{Func(4,8)}");
