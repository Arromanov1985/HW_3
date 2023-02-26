// 29. Написать программу вычисления произведения чисел от 1 до N

//Произведение суммы на число равно сумме произведений каждого слагаемого на это число. (a + b + c) · d = a · d + b · d + c · d (2 + 5 + 3) · 2 = 2 · 2 + 5 · 2 + 3 · 2 = 20 

Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());

int factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
    result=result*i;
    }
    return result;
}
Console.WriteLine(factorial(number));