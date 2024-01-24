using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {  
        string[] workArray = FillArray();
        string[] resultArray = GenerateNewArray(workArray);
        string firstArray = PrintArray(workArray);
        string secondArray = PrintArray(resultArray);
        Console.WriteLine(firstArray + " -> " + secondArray);
    }

    static string[] FillArray()
    {
        Console.WriteLine("Введите данные: ");
        string enterSymbols = Console.ReadLine() ?? string.Empty;
        char[] separators = { ',', ' ' };
        return enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    }

    static string PrintArray(string[] workArray)
    {
        return "[" + string.Join(", ", workArray.Select(item => $"\"{item}\"")) + "]";
    }

    static string[] GenerateNewArray(string[] workArray)
    {
        return workArray.Where(item => item.Length <= 3).ToArray();
    }
}