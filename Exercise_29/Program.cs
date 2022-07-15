// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1,33 -> [6, 1, 33]
Console.WriteLine("Введите размер массива");
int a=Convert.ToInt32(Console.Readline());
int[] array= new int [a];
for(int i=0; i<array.Length; i++){
    array[i]= new Random().Next(0,100);
}
Console.WriteLine("["+string.Join(",",array)+"]");
