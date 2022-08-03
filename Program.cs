using System;
using static System.Console;

Clear();
WriteLine("Это программа, которая просит у пользователя ввести с клавиатуры массив из строк. Затем показывает строки, длина которых меньше или равна трем символам.");

Write("Введите элементы массива (через пробелы или запятые): ");
string [] arrayFromUser = GetArrayFromString(ReadLine());
WriteLine("Вы ввели вот такой массив: ");
PrintArray (arrayFromUser);
WriteLine("В данном массиве содержатся следующие строки, длина которых меньше или равна трем символам: ");
PrintArray (GetStringLessThanFourChar(arrayFromUser));

string [] GetArrayFromString (string arrayStr)
{
    string [] array = arrayStr.Split(new char[]{' ',','},StringSplitOptions.RemoveEmptyEntries);
    string [] result = new string [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result [i] = array [i];
    }
    return result;
}

string [] GetStringLessThanFourChar (string [] array)
{
    int count = 0;
    string [] result = new string [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if ((array [i]).Length < 4) 
        {
            result [count] = array [i];
            count++;
        } 
    }
    return result;
}

void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write ($"{array[i]}\t");
    }
    WriteLine();
}
