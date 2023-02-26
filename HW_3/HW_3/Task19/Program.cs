//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Enter a number: ");
string? number = Console.ReadLine();
int Len1 = number.Length;

if (Len1 == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - palindrome");
    }
    else
    {
        Console.WriteLine($"{number} - Not а palindrome");
    }
}
else
{
    Console.WriteLine($"Error: {number} - is not a five - digit");
}

