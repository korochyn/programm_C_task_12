// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Ввелите число A - ");
int number_1 = int.Parse(Console.ReadLine()!);
int number_2 = number_1;
//Определение длины числа
int lenght = 0;
while (number_2 > 0) {number_2=number_2/10; lenght++;}
Console.WriteLine("Длина числа = " + lenght);
number_2 = number_1;
int[] nums1 = new int[lenght];
int del = 10;
int count = 0;
while (count < lenght)
     {
    nums1[count] = number_2 % del;
    //Console.Write(nums1[count]+" ");
    number_2 = number_2 /10;
    count++; 
    }
int result = 0;    
for (int i = 0 ; i < lenght; i++)    
    result = result + nums1[i];
Console.WriteLine(result);