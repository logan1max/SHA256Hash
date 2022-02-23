using System;

namespace SHA256Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Encryption encryption = new Encryption();

            encryption.ReadFromFile();

            Console.WriteLine("Hello World!");
        }
    }
}
