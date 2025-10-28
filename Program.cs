using System;


    internal class Program
    {
        static void Main()
        {
        // 1. Definera en string som inehåller ett numer som text
        string numberAsString = "123";

        // 2. Konvertera strängen till ett heltal (int)
        int number = int.Parse(numberAsString);

        // 3. Skriv ut heltalet till konsolen
        Console.WriteLine(number);
    }
}

