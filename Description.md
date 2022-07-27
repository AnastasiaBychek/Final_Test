# Описание решения тестовой задачи

## Создание массива из строк

Для того, чтобы создать массив из строк, который будет заполняться значениями с клавиатуры, необходимо написать следующий метод:

 string [] FillArray() 

{
    string[] array = new string[4];

    for (int i = 0; i< array.Length; i++)
    {
        Console.WriteLine("Input array value");
        array[i] = Console.ReadLine();
    }
    return array;
} 
