using System;
using System.Collections.Generic;
using System.IO;

class Assembler
{

    static void Main()
    {
        string sourceCode = File.ReadAllText("program.asm");
        string[] lines = sourceCode.Split('\n');

        int[] code = Assemble(lines);

        string binary = "";
        for(int i = 0; i < lines.Length; i++)
        {
            binary += Convert.ToString(code[i], 2);
        }

        File.WriteAllText("code.exe", binary);
    }

    static int[] Assemble(string[] lines)
    {
        int address = 0;
        int[] code = new int[lines.Length];

        foreach (string line in lines)
        {
            string[] tokens = line.Split(' ', '\t');
            string instruction = tokens[0];

            switch (instruction.ToLower())
            {
                case "ld":
                    code[address] = 0;
                    break;

                case "st":
                    code[address] = 4;
                    break;

                case "be":
                    code[address] = 1;
                    break;

                case "bcs":
                    code[address] = 5;
                    break;

                case "bneg":
                    code[address] = 6;
                    break;

                case "bvs":
                    code[address] = 7;
                    break;

                case "ba":
                    code[address] = 8;
                    break;

                case "branch":
                    code[address] = 2;
                    break;

                case "sethi":
                    code[address] = 3;
                    break;

                case "addcc":
                    code[address] = 16;
                    break;

                case "andcc":
                    code[address] = 17;
                    break;

                case "orcc":
                    code[address] = 18;
                    break;

                case "orncc":
                    code[address] = 19;
                    break;

                case "srl":
                    code[address] = 38;
                    break;

                case "jmpl":
                    code[address] = 56;
                    break;

                default:
                    Console.WriteLine($"Eroare: Instrucțiune necunoscută - {instruction}");
                    break;
            }

            address++;
        }
        return code;
    }
}