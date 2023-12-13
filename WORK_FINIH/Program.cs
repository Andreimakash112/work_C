﻿//из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Ввод исходного массива
        string[] source = { "Hello", "2", "world", ":-)" };

        // Находим количество строк, длина которых меньше или равна 3 символам
        int count = 0;
        for (int i = 0; i < source.Length; i++)
        {
            if (source[i].Length <= 3)
            {
                count++;
            }
        }
        // Создаем новый массив для хранения результатов
        string[] result = new string[count];

        // Итерируемся по исходному массиву в обратном порядке
        for (int i = source.Length - 1; i >= 0; i--)
        {
            // Если длина строки меньше или равна 3 символам, добавляем ее в новый массив
            if (source[i].Length <= 3)
            {
                result[count - 1] = source[i];
                count--; // Уменьшаем count после добавления элемента
            }
        }
        // Вывод результатов
        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }
}
