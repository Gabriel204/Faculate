using System;

class Program
{
    static string ConvertToBinary(int decimalNumber, int numBits)
    {
        return Convert.ToString(decimalNumber, 2).PadLeft(numBits, '0');
    }

    static void DisplayBinaryClock(string currentTime)
    {
        string[] timeComponents = currentTime.Split(':');
        int hours = int.Parse(timeComponents[0]);
        int minutes = int.Parse(timeComponents[1]);
        int seconds = int.Parse(timeComponents[2]);

        string binaryHours = ConvertToBinary(hours, 6);
        string binaryMinutes = ConvertToBinary(minutes, 6);
        string binarySeconds = ConvertToBinary(seconds, 6);

        Console.WriteLine("Binary Clock:");
        Console.WriteLine("H H | M M | S S");

        for(int i = 0; i < 6; i++)
        {
            Console.WriteLine($"  {binaryHours[i]} |   {binaryMinutes[i]} |   {binarySeconds[i]}");
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Introduceți ora curentă (format HH:MM:SS): ");
            string currentTime = Console.ReadLine();
            DisplayBinaryClock(currentTime);
        }
        catch (FormatException)
        {
            Console.WriteLine("Formatul orei introdus este invalid. Folosiți formatul HH:MM:SS.");
        }
    }
}
