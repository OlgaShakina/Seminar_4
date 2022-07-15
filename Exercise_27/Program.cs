// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -< 11
//82 -< 10
//9012 -< 12
Console.WriteLine("Введите целое число ");
int a=Convert.ToInt32(Console.ReadLine());
int sum= Convert.ToString(a)[0];
for(int i=1;a%(Math.Pow(10,i))==a; i++){
sum=sum+Convert.ToString(a)[i];
}
Console.WriteLine(sum);