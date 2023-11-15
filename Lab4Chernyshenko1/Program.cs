int[] mas= new int[15];
Console.WriteLine("Введите 15 двузначных целых чисел:");

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = int.Parse(Console.ReadLine());
}


int[] newmas = new int[mas.Length];

for (int i = 0; i < mas.Length; i++)
{
    newmas[i] = SwapDigits(mas[i]);
}
Console.WriteLine("\nИсходный массив:");
PrintArray(mas);

Console.WriteLine("\nНовый массив:");
PrintArray(newmas);
    static int SwapDigits(int number)
{
    int tensDigit = number / 10;
    int unitsDigit = number % 10;

    return unitsDigit * 10 + tensDigit;
}
static void PrintArray(int[] array)
{
    foreach (var element in array)
    {
        Console.Write(element + " ");
    }

    Console.WriteLine();
}