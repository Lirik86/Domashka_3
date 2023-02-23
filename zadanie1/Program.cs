int inpupint(string msg)
{
    System.Console.WriteLine($"{msg} >");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}
bool validate(int num)
{
    if (num < 10000 || num > 99999)
    {
        System.Console.WriteLine("Вы ввели не пятизначное число!");
        return false;
    }
        return true;
}

bool palindrom(int num)
{
    int a = num / 10000;
    int b = num % 10;
    int c = (num / 1000) % 10;
    int d = (num / 10) % 10;
    if (a == b && c == d)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int number = inpupint("Введите пятизначное число: ");
if (validate(number))
{
   if (palindrom(number))
   {
        System.Console.WriteLine("Данное число является полиндромом!");
   }
   else
   {
        System.Console.WriteLine("Это число не полиндром!");
   }
}


