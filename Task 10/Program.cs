// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

void Test(int a){
    if (a>99 && a<1000)
    {
       int dec = a / 10 % 10;
       System.Console.WriteLine($"Вторая цифра введенного числа: {dec}");
    }
    else
    {
        System.Console.WriteLine("Error");
    }
}

System.Console.Write("Введите трёхзначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
Test(numb);