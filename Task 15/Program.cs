// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void Test(int a){
    if (a>0 && a<8)
    {
        if (a>0 && a<6)
        {
            System.Console.WriteLine("Это будний день");
        }
        else System.Console.WriteLine("Это выходной");
    }
    else System.Console.WriteLine("Такого дня недели нет");
}

System.Console.Write("Введите цифру дня недели: ");
int numb = Convert.ToInt32(Console.ReadLine());
Test(numb);