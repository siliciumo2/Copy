using System;
using System.Diagnostics;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string file1 = @"C:\Users\Users\OneDrive\Документы\учеба\Системное программирование\copy1.txt";
        string papka1 = @"C:\Users\Users\OneDrive\Документы\учеба\Системное программирование\copy1.txt";
        string file2 = @"C:\Users\Users\OneDrive\Документы\учеба\Системное программирование\copy2.txt";
        string papka2 = @"C:\Users\Users\OneDrive\Документы\учеба\Системное программирование\copy2.txt";

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        CopyFile(file1, papka1);
        stopwatch.Stop();
        Console.WriteLine($"время копирований file1 {stopwatch.Elapsed.TotalMilliseconds}");

        stopwatch.Reset();
        stopwatch.Start();
        CopyFile(file2, papka2);
        stopwatch.Stop();
        Console.WriteLine($"время копирования file2 {stopwatch.Elapsed.TotalMilliseconds}");
    }

    static void CopyFile(string papkapapki, string papkapapki2)
    {
        try
        {
            File.Copy(papkapapki, papkapapki2, true); 
            Console.WriteLine($"файл {papkapapki} скопирован в {papkapapki2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ошибочка вышла {papkapapki2} {ex.Message}");
        }
    }
}