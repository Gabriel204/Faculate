using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti numarul: ");
        string inputNumber = Console.ReadLine();

        Console.WriteLine("Introduceti baza initiala: ");
        int baza1 = int.Parse(Console.ReadLine());

        if(baza1 < 2 || baza1 > 16) {
            Console.WriteLine("Baza nu corespunde! bazele permise sunt intre 2 si 16");
            return;
        }

        Console.WriteLine("Introduceti baza de destinatie: ");
        int baza2 = int.Parse(Console.ReadLine());

        if(baza2 < 2 || baza2 > 16) {
            Console.WriteLine("Baza nu corespunde! bazele permise sunt intre 2 si 16");
            return;
        }

        string result = ConvertBase(inputNumber, baza1, baza2);

        Console.WriteLine($"Rezultatul conversiei: {result}");
    }

    static string ConvertBase(string inputNumber, int baza1, int baza2)
    {
        string[] parts = inputNumber.Split('.');

        int decimalInteger = ConvertToDecimal(parts[0], baza1);

        double decimalFraction = ConvertFractionToDecimal(parts.Length > 1 ? parts[1] : "0", baza1);

        double decimalNumber = decimalInteger + decimalFraction;

        string result = ConvertFromDecimal(decimalNumber, baza2);

        return result;
    }

    static int ConvertToDecimal(string inputNumber, int baza1)
    {
        int result = 0;
        int power = 1;

        for (int i = inputNumber.Length - 1; i >= 0; i--)
        {
            int digit = GetDigitValue(inputNumber[i]);
            result += digit * power;
            power *= baza1;
        }

        return result;
    }

    static double ConvertFractionToDecimal(string fractionPart, int baza1)
    {
        double result = 0;
        double power = 1.0 / baza1;

        for (int i = 0; i < fractionPart.Length; i++)
        {
            int digit = GetDigitValue(fractionPart[i]);
            result += digit * power;
            power /= baza1;
        }

        return result;
    }

    static string ConvertFromDecimal(double decimalNumber, int baza2)
    {
        string result = "";
        int integerPart = (int)decimalNumber;

        result += ConvertFromDecimal(integerPart, baza2);

        if (decimalNumber != integerPart)
        {
            result += ".";

            double fractionPart = decimalNumber - integerPart;

            for (int i = 0; i < 5; i++)
            {
                fractionPart *= baza2;
                int digit = (int)fractionPart;
                result += GetCharValue(digit);
                fractionPart -= digit;
            }
        }

        return result;
    }

    static string ConvertFromDecimal(int decimalNumber, int baza2)
    {
        string result = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % baza2;
            char digitChar = GetCharValue(remainder);
            result = digitChar + result;
            decimalNumber /= baza2;
        }
        return result == "" ? "0" : result;
    }

    static int GetDigitValue(char digitChar)
    {
        return char.IsDigit(digitChar) ? digitChar - '0' : char.ToUpper(digitChar) - 'A' + 10;
    }

    static char GetCharValue(int value)
    {
        return value < 10 ? (char)('0' + value) : (char)('A' + value - 10);
    }
}