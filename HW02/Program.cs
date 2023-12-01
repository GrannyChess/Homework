Console.Clear();

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);  // [1, 99]
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();

int count = 0;
for (int i = 0; i < 10; i++) 
    if (array[i] % 2 == 0)
    {
        count++;
    }  
Console.WriteLine("Количество чётных чисел в массиве - " + count); //выводим на экран
Console.WriteLine();