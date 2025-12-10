// See https://aka.ms/new-console-template for more information
using System;

public class Program{
    public static void Main(String[] args) {
        ComputerHash ch = new ComputerHash();
        
        Console.WriteLine("Enter the file path: ");
        string path = Console.ReadLine();

        string hash = ch.ComputeHash(path);

        Console.WriteLine("Hash: ");
        Console.WriteLine(hash);
    }
}