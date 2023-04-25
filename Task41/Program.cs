// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void FillArrayKeyboard(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
      Console.Write($"Введите {i+1} число массива: ");  
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {

        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}


int FindElement(int[] numbers)
{

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum ++;
        }

    }
    return sum;
}


    
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];    
    FillArrayKeyboard(numbers);
    PrintArray(numbers);
    int sum = FindElement(numbers);
    Console.WriteLine($"Количесвто чисел больше нуля: {sum}");