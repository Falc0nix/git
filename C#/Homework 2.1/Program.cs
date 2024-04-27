System.Console.Write("Введите искомое число: ");
int value = Convert.ToInt32(Console.ReadLine());

if (value % 7 == 0 && value % 23 == 0)
{
    Console.WriteLine($"Заданное число {value} проверку. Оно кратно и 7, и 23");
}
else
{
    Console.WriteLine($"Заданное число {value} не прошло проверку");
}