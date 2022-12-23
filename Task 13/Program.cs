// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void Test(int a){
    int i=0;
    int b=a;
    while(b>0) {
        i++;
        b/=10;
    }
    System.Console.WriteLine($"Количество цифр в числе: {i}");
    if (i>=3)
    {
       int step = Convert.ToInt32(Math.Pow(10, i-3));
       int dec = a / step % 10;
       System.Console.WriteLine($"Третья цифра введенного числа: {dec}");
    }
    else
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
}

System.Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
Test(numb);