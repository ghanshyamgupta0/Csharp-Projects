using System;
using System.Security.Cryptography;

public class HashComputer {
    public string ComputeHash (string filepath) {
        Console.WriteLine("This is the Computer Hash.");

        using var stream = File.OpenRead(filepath);
        Console.WriteLine(stream);
        // using var sha256 = SHA256.Create();

        // byte[] hashBytes = sha256.ComputeHash(stream);

        // return BitConverter.ToString(hashBytes).Replace("_", " ").ToLower();
    }
}