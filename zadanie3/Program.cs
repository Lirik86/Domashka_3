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
int[] Cubrt(int num)
{
    int a;
    if (num < 1)
    {
        a = num * -1;
    }
    else
    {
        a = num;
    }
    int[] Array = new int[a];
    int index = 0;
    if (num > 1)
    {
        int count = 1;
        Array[index] = count;
        while (index < num)
        {
            Array[index] = count*count*count;
            index++;
            count++;
        }
    }
    if (num < 1)
    {
        int b = num*-1;
        int count = -1;
        Array[index] = count;
        while (index < b)
        {
            Array[index] = count*count*count;
            index++;
            count--;
        }
    }
    return Array;
}
int number = inpupint("Введите целое число: ");
int[] number1 = Cubrt(number);
for (int i = 0; i < number1.Length; i++)
{
    System.Console.Write(number1[i] + " ");
}