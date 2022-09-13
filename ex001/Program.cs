System.Console.WriteLine("Введите 5ти значное число и магия определит является ли оно палиндромом");
string p = Console.ReadLine();

void CheckingNumber (string p)
{
    if( p[0] == p[4] || p[1] == p[3]){
    System.Console.WriteLine($"Ваше число {p} - палиндром");
}
else 
    System.Console.WriteLine($"Ваше число {p} - не палиндром");
}
if (p.Length == 5)
{
    CheckingNumber(p);
}
else
{
    System.Console.WriteLine("Введите правильное число");
}