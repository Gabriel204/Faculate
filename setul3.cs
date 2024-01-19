using System;
using System.Collections.Generic;
using System.Linq;

namespace tema
{
    class tema
    {
        static void Main(string[] args)
        {
            P31();
        }

        //Calculati suma elementelor unui vector de n numere citite de la tastatura. 
        //Rezultatul se va afisa pe ecran.

        private static void P1()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            int sum = 0;
            foreach(string num in nums)
            {
                int.TryParse(num, out int n);
                sum += n;
            }

            Console.WriteLine(sum);
        }

        //Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din 
        //vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
        private static void P2()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            Console.Write("Introduceti numarul k= ");
            int k = Convert.ToInt32(Console.ReadLine());

            string[] nums = input.Split(' ');

            int pos = -1;
            for(int i = 0; i < nums.Length; i++)
            {
                int.TryParse(nums[i], out int num);
                if(num == k) {
                    pos = i;
                    break;
                }
            }

            Console.WriteLine(pos);
        }

        //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
        // Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 

        private static void P3()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            int maxpos = 0;
            int minpos = 0;

            int maxnum = 0;
            int minnum = int.MaxValue;

            for(int i = 0; i < nums.Length; i++)
            {
                int.TryParse(nums[i], out int num);
                if(num > maxnum)
                {
                    maxnum = num;
                    maxpos = i;
                }

                if(num < minnum)
                {
                    minnum = num;
                    minpos = i;
                }
            }

            Console.WriteLine($"min {minnum} {minpos} max {maxnum} {maxpos}");
        }

        //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si 
        //de cate ori apar acestea. 

        private static void P4()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            Dictionary<int, int> numsdata = new Dictionary<int, int>();

            int maxnum = 0;
            int minnum = int.MaxValue;

            for(int i = 0; i < nums.Length; i++)
            {
                int.TryParse(nums[i], out int num);

                if(numsdata.ContainsKey(num))
                    numsdata[num] += 1;
                else
                    numsdata.Add(num, 1);

                if(num > maxnum)
                    maxnum = num;

                if(num < minnum)
                    minnum = num;
            }

            Console.WriteLine($"max {maxnum} : {numsdata[maxnum]} min {minnum} : {numsdata[minnum]}");
        }

        //Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze 
        //valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 
        private static void P5()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            Console.Write("k= ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("e= ");
            string e = Console.ReadLine();


            string[] numbers = new string[nums.Length + 1]; 
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == k)
                    numbers[i] = e;
                else if(i > k)
                    numbers[i] = nums[i - 1];
                else
                    numbers[i] = nums[i];
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }

        //Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul 
        //de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie 
        //spre stanga.

        private static void P6()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            Console.Write("k= ");
            int k = Convert.ToInt32(Console.ReadLine());


            string[] numbers = new string[nums.Length]; 
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == k)
                {
                    continue;
                }
                if(i > k)
                    numbers[i - 1] = nums[i];
                else
                    numbers[i] = nums[i];

            }

            foreach (string str in numbers)
            {
                Console.Write($"{str} ");
            }
        }

        //Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. 
        //Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

        private static void P7()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            string[] reverse = new string[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                reverse[i] = nums[nums.Length - i - 1];
            }

            foreach (string str in reverse)
            {
                Console.Write($"{str} ");
            }
        }

        //Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. 
        //Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.

        private static void P8()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            string temp = nums[0];
            nums[0] = nums[nums.Length - 1];
            nums[nums.Length - 1] = temp;

            foreach (string str in nums)
            {
                Console.Write($"{str} ");
            }
        }

        //Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
        private static void P9()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            Console.Write("k= ");
            int k = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < k; i++)
            {
                string temp = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = temp;
            }

            foreach (string str in nums)
            {
                Console.Write($"{str} ");
            }
        }

        //Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.
        //Se cere sa se determine pozitia unui element dat k. 
        //Daca elementul nu se gaseste in vector rezultatul va fi -1. 

        private static int Search(string[] nums, int k)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left <= right)
            {
                int mid = (int) Math.Floor((decimal)(left + right) / 2);
                int.TryParse(nums[mid], out int num);
                if(num < k)
                    left = mid + 1;
                else if(num > k)
                    right = mid - 1;
                else
                    return mid;
            }
            return -1;
        }
        private static void P10()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            Console.Write("k= ");
            int k = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine(Search(nums, k));
        }

        //Se da un numar natural n. Se cere sa se afiseze toate numerele 
        //prime mai mici sau egale cu n (ciurul lui Eratostene). 

        private static void P11()
        {
            Console.Write("Introduceți un număr n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool[] isPrime = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            Console.Write($"Numere prime până la {n}: ");
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                    Console.Write($"{i} ");
            }
        }

        //Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
        private static void P12()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            for (int i = 0; i < nums.Length; i++) {
                int minIndex = i;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (int.Parse(nums[j]) < int.Parse(nums[minIndex]))
                    {
                        minIndex = j;
                    }
                }
                string temp = nums[minIndex];
                nums[minIndex] = nums[i];
                nums[i] = temp;
            }

            foreach (string str in nums)
            {
                Console.Write($"{str} ");
            }
        }

        //Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 

        private static void P13()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            int i = 1;
            while(i < nums.Length)
            {
                int j = i;
                while(j > 0 && int.Parse(nums[j - 1]) > int.Parse(nums[j]))
                {
                    string temp = nums[j];
                    nums[j] = nums[j - 1];
                    nums[j - 1] = temp;
                    j--;
                }
                i++;
            }
            
            foreach (string str in nums)
            {
                Console.Write($"{str} ");
            }
        }

        //Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa 
        //ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un 
        //algoritm eficient - se va face o singura parcugere a vectorului). 

        private static void P14()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            int n = nums.Length - 1;
            for(int i = 0; i < nums.Length; i++)
            {
                if(i >= n)
                    break;
                if(int.Parse(nums[i]) == 0)
                {
                    string temp = nums[n];
                    nums[n] = nums[i];
                    nums[i] = temp;
                    n--;
                }
            }

            foreach (string str in nums)
            {
                Console.Write($"{str} ");
            }
        }

        //Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
        private static void P15()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j])
                    {
                        nums[j] = "0";
                    }
                }
            }

            foreach (string str in nums)
            {
                Console.Write($"{str} ");
            }
        }

        //Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.

        private static int CalculeazaCMMD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private static void P16()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');

            int cmmd = int.Parse(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                cmmd = CalculeazaCMMD(cmmd, int.Parse(nums[i]));
            }

            Console.WriteLine(cmmd);
        }

        //Se da un numar n in baza 10 si un numar b. 1 < b < 17. 
        //Sa se converteasca si sa se afiseze numarul n in baza b. 
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

        static string ConvertBase(string inputNumber, int baza1, int baza2)
        {
            string[] parts = inputNumber.Split('.');

            int decimalInteger = ConvertToDecimal(parts[0], baza1);

            double decimalFraction = ConvertFractionToDecimal(parts.Length > 1 ? parts[1] : "0", baza1);

            double decimalNumber = decimalInteger + decimalFraction;

            string result = ConvertFromDecimal(decimalNumber, baza2);

            return result;
        }

        private static void P17()
        {
            Console.Write("Introduceti numarul: ");
            string inputNumber = Console.ReadLine();

            Console.Write("Introduceti baza initiala: ");
            int baza1 = int.Parse(Console.ReadLine());

            if(baza1 < 2 || baza1 > 16) {
                Console.WriteLine("Baza nu corespunde! bazele permise sunt intre 2 si 16");
                return;
            }

            Console.Write("Introduceti baza de destinatie: ");
            int baza2 = int.Parse(Console.ReadLine());

            if(baza2 < 2 || baza2 > 16) {
                Console.WriteLine("Baza nu corespunde! bazele permise sunt intre 2 si 16");
                return;
            }

            string result = ConvertBase(inputNumber, baza1, baza2);

            Console.WriteLine($"Rezultatul conversiei: {result}");
        }

        //Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. 
        //Cel mai putin semnificativ coeficient este pe pozitia zero in vector. 
        //Se cere valoarea polinomului intr-un punct x. 
        private static void P18()
        {
            Console.Write("Introduceti coeficientii: ");
            string input = Console.ReadLine();

            Console.Write("Introduceti coeficientul: ");
            int x = Convert.ToInt32(Console.ReadLine());

            string[] nums = input.Split(' ');

            double rezultat = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                rezultat += int.Parse(nums[i]) * Math.Pow(x, i);
            }

            Console.WriteLine(rezultat);
        }

        //Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). 
        //Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] 
        //atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 

        private static void P19()
        {
            Console.Write("Introduceti numerele: ");
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');

            Console.Write("Introduceti sirul p: ");
            string arr = Console.ReadLine();
            string[] p = arr.Split(' ');

            if (nums.Length < p.Length)
                return;

            int aparitii = 0;

            for (int i = 0; i <= nums.Length - p.Length; i++)
            {
                bool potrivire = true;
                for (int j = 0; j < p.Length; j++)
                {
                    if (nums[i + j] != p[j])
                    {
                        potrivire = false;
                        break;
                    }
                }

                if (potrivire)
                    aparitii++;
            }

            Console.WriteLine(aparitii);
        }

        //Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. 
        //Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel 
        //incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 
        private static void P20()
        {
            Console.Write("Introduceti numarul de margele albe: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');

            Console.Write("Introduceti numarul de margele negre: ");
            string arr = Console.ReadLine();
            string[] s2 = arr.Split(' ');

            int numarSuprapuneri = 0;
            int lungimeS1 = s1.Length;
            int lungimeS2 = s2.Length;

            for (int i = 0; i < lungimeS1 + lungimeS2 - 1; i++)
            {
                bool potrivire = true;
                for (int j = 0; j < Math.Min(lungimeS1, lungimeS2); j++)
                {
                    int indexS1 = i - j;
                    int indexS2 = j;

                    if (indexS1 >= 0 && indexS1 < lungimeS1 && indexS2 >= 0 && indexS2 < lungimeS2)
                    {
                        if (s1[indexS1] == s2[indexS2])
                        {
                            potrivire = false;
                            break;
                        }
                    }
                }

                if (potrivire)
                    numarSuprapuneri++;
            }

            Console.WriteLine($"suprapuneri {numarSuprapuneri}");
        }


        //Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica 
        //(care ar trebui sa apara primul in dictionar). 

        static int ComparareLexicografica(int[] vector1, int[] vector2)
        {
            int lungimeMinima = Math.Min(vector1.Length, vector2.Length);

            for (int i = 0; i < lungimeMinima; i++)
            {
                if (vector1[i] < vector2[i])
                    return -1; 
                else if (vector1[i] > vector2[i])
                    return 1; 
            }

            if (vector1.Length < vector2.Length)
                return -1;
            else if (vector1.Length > vector2.Length)
                return 1;

            return 0;
        }
        private static void P21()
        {
            Console.Write("Introduceti numarul 1: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');
            int[] vector1 = Array.ConvertAll(s1, int.Parse);

            Console.Write("Introduceti numarul 2: ");
            string arr = Console.ReadLine();
            string[] s2 = arr.Split(' ');
            int[] vector2 = Array.ConvertAll(s2, int.Parse);

            
            int rezultat = ComparareLexicografica(vector1, vector2);

            if (rezultat < 0)
                Console.WriteLine("Vectorul 1 este lexicografic mai mic.");
            else if (rezultat > 0)
                Console.WriteLine("Vectorul 2 este lexicografic mai mic.");
            else
                Console.WriteLine("Vectorii sunt identici lexicografic.");

        }

        //Se dau doi vectori v1 si v2. Se cere sa determine intersectia, 
        //reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). 
        //Elementele care se repeta vor fi scrise o singura data in rezultat. 

        static HashSet<int> Intersectie(int[] v1, int[] v2)
        {
            HashSet<int> set1 = new HashSet<int>(v1);
            HashSet<int> set2 = new HashSet<int>(v2);

            set1.IntersectWith(set2);

            return set1;
        }

        static HashSet<int> Reuniune(int[] v1, int[] v2)
        {
            HashSet<int> set1 = new HashSet<int>(v1);
            HashSet<int> set2 = new HashSet<int>(v2);

            set1.UnionWith(set2);

            return set1;
        }

        static HashSet<int> DiferentaV1MinusV2(int[] v1, int[] v2)
        {
            HashSet<int> set1 = new HashSet<int>(v1);
            HashSet<int> set2 = new HashSet<int>(v2);

            set1.ExceptWith(set2);

            return set1;
        }
        static HashSet<int> DiferentaV2MinusV1(int[] v1, int[] v2)
        {
            HashSet<int> set1 = new HashSet<int>(v1);
            HashSet<int> set2 = new HashSet<int>(v2);

            set2.ExceptWith(set1);

            return set2;
        }

        private static void P22()
        {
            Console.Write("Introduceti numarul 1: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');
            int[] vector1 = Array.ConvertAll(s1, int.Parse);

            Console.Write("Introduceti numarul 2: ");
            string arr = Console.ReadLine();
            string[] s2 = arr.Split(' ');
            int[] vector2 = Array.ConvertAll(s2, int.Parse);

            HashSet<int> intersectie = Intersectie(vector1, vector2);
            Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));

            // Reuniunea
            HashSet<int> reuniune = Reuniune(vector1, vector2);
            Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));

            // Diferenta v1 - v2
            HashSet<int> diferentaV1MinusV2 = DiferentaV1MinusV2(vector1, vector2);
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1MinusV2));

            // Diferenta v2 - v1
            HashSet<int> diferentaV2MinusV1 = DiferentaV2MinusV1(vector1, vector2);
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2MinusV1));
        }

        static List<int> Intersectie2(int[] v1, int[] v2)
        {
            List<int> intersectie = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    intersectie.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return intersectie;
        }

        static List<int> Reuniune2(int[] v1, int[] v2)
        {
            List<int> reuniune = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    reuniune.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    reuniune.Add(v1[i]);
                    i++;
                }
                else
                {
                    reuniune.Add(v2[j]);
                    j++;
                }
            }

            while (i < v1.Length)
            {
                reuniune.Add(v1[i]);
                i++;
            }

            while (j < v2.Length)
            {
                reuniune.Add(v2[j]);
                j++;
            }

            return reuniune;
        }

            static List<int> DiferentaV1MinusV22(int[] v1, int[] v2)
        {
            List<int> diferenta = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    diferenta.Add(v1[i]);
                    i++;
                }
                else
                {
                    j++;
                }
            }

            while (i < v1.Length)
            {
                diferenta.Add(v1[i]);
                i++;
            }

            return diferenta;
        }

        static List<int> DiferentaV2MinusV12(int[] v1, int[] v2)
        {
            List<int> diferenta = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    i++;
                }
                else
                {
                    diferenta.Add(v2[j]);
                    j++;
                }
            }

            while (j < v2.Length)
            {
                diferenta.Add(v2[j]);
                j++;
            }

            return diferenta;
        }


        //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  
        //sunt in ordine strict crescatoare. 
        private static void P23()
        {
            Console.Write("Introduceti numarul 1: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');
            int[] v1 = Array.ConvertAll(s1, int.Parse);

            Console.Write("Introduceti numarul 2: ");
            string arr = Console.ReadLine();
            string[] s2 = arr.Split(' ');
            int[] v2 = Array.ConvertAll(s2, int.Parse);

            List<int> intersectie = Intersectie2(v1, v2);
            Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));

            // Reuniunea
            List<int> reuniune = Reuniune2(v1, v2);
            Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));

            // Diferenta v1 - v2
            List<int> diferentaV1MinusV2 = DiferentaV1MinusV22(v1, v2);
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1MinusV2));

            // Diferenta v2 - v1
            List<int> diferentaV2MinusV1 = DiferentaV2MinusV12(v1, v2);
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2MinusV1));
        }

        //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori 
        //cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).

        static int[] Intersectie3(int[] v1, int[] v2)
        {
            int lungime = Math.Min(v1.Length, v2.Length);
            int[] intersectie = new int[lungime];

            for (int i = 0; i < lungime; i++)
            {
                intersectie[i] = v1[i] & v2[i];
            }

            return intersectie;
        }

        static int[] Reuniune3(int[] v1, int[] v2)
        {
            int lungime = Math.Max(v1.Length, v2.Length);
            int[] reuniune = new int[lungime];

            for (int i = 0; i < lungime; i++)
            {
                if (i < v1.Length && i < v2.Length)
                {
                    reuniune[i] = v1[i] | v2[i];
                }
                else if (i < v1.Length)
                {
                    reuniune[i] = v1[i];
                }
                else
                {
                    reuniune[i] = v2[i];
                }
            }

            return reuniune;
        }

        static int[] DiferentaV1MinusV23(int[] v1, int[] v2)
        {
            int lungime = Math.Max(v1.Length, v2.Length);
            int[] diferenta = new int[lungime];

            for (int i = 0; i < lungime; i++)
            {
                if (i < v1.Length && i < v2.Length)
                {
                    diferenta[i] = v1[i] & ~v2[i];
                }
                else if (i < v1.Length)
                {
                    diferenta[i] = v1[i];
                }
            }

            return diferenta;
        }

        static int[] DiferentaV2MinusV13(int[] v1, int[] v2)
        {
            int lungime = Math.Max(v1.Length, v2.Length);
            int[] diferenta = new int[lungime];

            for (int i = 0; i < lungime; i++)
            {
                if (i < v1.Length && i < v2.Length)
                {
                    diferenta[i] = v2[i] & ~v1[i];
                }
                else if (i < v2.Length)
                {
                    diferenta[i] = v2[i];
                }
            }

            return diferenta;
        }


        private static void P24()
        {   
            Console.Write("Introduceti numarul 1: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');
            int[] v1 = Array.ConvertAll(s1, int.Parse);

            Console.Write("Introduceti numarul 2: ");
            string arr = Console.ReadLine();
            string[] s2 = arr.Split(' ');
            int[] v2 = Array.ConvertAll(s2, int.Parse);

            int[] intersectie = Intersectie3(v1, v2);
            Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));

            // Reuniunea
            int[] reuniune = Reuniune3(v1, v2);
            Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));

            // Diferenta v1 - v2
            int[] diferentaV1MinusV2 = DiferentaV1MinusV23(v1, v2);
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1MinusV2));

            // Diferenta v2 - v1
            int[] diferentaV2MinusV1 = DiferentaV2MinusV13(v1, v2);
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2MinusV1));
        }

        //(Interclasare) Se dau doi vector sortati crescator v1 si v2. 
        //Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. 
        //Sunt permise elemente duplicate. 
        static int[] InterclasareVectori(int[] v1, int[] v2)
        {
            int lungimeV1 = v1.Length;
            int lungimeV2 = v2.Length;
            int[] rezultat = new int[lungimeV1 + lungimeV2];

            int i = 0, j = 0, k = 0;

            while (i < lungimeV1 && j < lungimeV2)
            {
                if (v1[i] <= v2[j])
                {
                    rezultat[k] = v1[i];
                    i++;
                }
                else
                {
                    rezultat[k] = v2[j];
                    j++;
                }
                k++;
            }

            while (i < lungimeV1)
            {
                rezultat[k] = v1[i];
                i++;
                k++;
            }

            while (j < lungimeV2)
            {
                rezultat[k] = v2[j];
                j++;
                k++;
            }

            return rezultat;
        }

        private static void P25()
        {
            Console.Write("Introduceti numarul 1: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');
            int[] v1 = Array.ConvertAll(s1, int.Parse);

            Console.Write("Introduceti numarul 2: ");
            string arr = Console.ReadLine();
            string[] s2 = arr.Split(' ');
            int[] v2 = Array.ConvertAll(s2, int.Parse);

            int[] rezultat = InterclasareVectori(v1, v2);

            Console.WriteLine("Vectorul interclasat: " + string.Join(", ", rezultat));
        }

        //Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un 
        //vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul 
        //a doua astfel de numere. 

        static List<int> Adunare(List<int> numar1, List<int> numar2)
        {
            List<int> rezultat = new List<int>();
            int carry = 0;

            int lungimeMaxima = Math.Max(numar1.Count, numar2.Count);

            for (int i = 0; i < lungimeMaxima || carry != 0; i++)
            {
                int cifra1 = (i < numar1.Count) ? numar1[i] : 0;
                int cifra2 = (i < numar2.Count) ? numar2[i] : 0;

                int suma = cifra1 + cifra2 + carry;
                carry = suma / 10;
                rezultat.Add(suma % 10);
            }

            return rezultat;
        }


        static List<int> Scadere(List<int> numar1, List<int> numar2)
        {
            List<int> rezultat = new List<int>();
            int borrow = 0;

            int lungimeMaxima = Math.Max(numar1.Count, numar2.Count);

            for (int i = 0; i < lungimeMaxima || borrow != 0; i++)
            {
                int cifra1 = (i < numar1.Count) ? numar1[i] : 0;
                int cifra2 = (i < numar2.Count) ? numar2[i] : 0;

                int diferenta = cifra1 - cifra2 - borrow;
                if (diferenta < 0)
                {
                    diferenta += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }

                rezultat.Add(diferenta);
            }
            while (rezultat.Count > 1 && rezultat.Last() == 0)
            {
                rezultat.RemoveAt(rezultat.Count - 1);
            }

            return rezultat;
        }
        
        static List<int> Inmultire(List<int> numar1, List<int> numar2)
        {
            int lungimeNumar1 = numar1.Count;
            int lungimeNumar2 = numar2.Count;

            List<int> rezultat = new List<int>(new int[lungimeNumar1 + lungimeNumar2]);

            for (int i = 0; i < lungimeNumar1; i++)
            {
                int carry = 0;
                for (int j = 0; j < lungimeNumar2 || carry != 0; j++)
                {
                    int produs = rezultat[i + j] + numar1[i] * (j < lungimeNumar2 ? numar2[j] : 0) + carry;
                    rezultat[i + j] = produs % 10;
                    carry = produs / 10;
                }
            }
            while (rezultat.Count > 1 && rezultat.Last() == 0)
            {
                rezultat.RemoveAt(rezultat.Count - 1);
            }

            return rezultat;
        }

        private static void P26()
        {
            Console.Write("Introduceti numarul 1: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');

            Console.Write("Introduceti numarul 2: ");
            string arr = Console.ReadLine();
            string[] s2 = arr.Split(' ');

            List<int> numar1 = new List<int>();
            foreach (string num in s1)
            {
                if (int.TryParse(num, out int numar))
                {
                    numar1.Add(numar);
                }
            }
            List<int> numar2 = new List<int>();
            foreach (string num in s2)
            {
                if (int.TryParse(num, out int numar))
                {
                    numar2.Add(numar);
                }
            }

            List<int> suma = Adunare(numar1, numar2);
            Console.WriteLine("Suma: " + string.Join("", suma));

            List<int> diferenta = Scadere(numar1, numar2);
            Console.WriteLine("Diferenta: " + string.Join("", diferenta));

            List<int> produs = Inmultire(numar1, numar2);
            Console.WriteLine("Produsul: " + string.Join("", produs));
        }

        // Se da un vector si un index in vectorul respectiv. 
        //Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 

        static int ValoareDupaSortare(int[] vector, int index)
        {
            int[] copieVector = new int[vector.Length];
            Array.Copy(vector, copieVector, vector.Length);

            Array.Sort(copieVector);

            return copieVector[index];
        }

        private static void P27()
        {
            Console.Write("Introduceti numarul 1: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');
            int[] v1 = Array.ConvertAll(s1, int.Parse);

            Console.Write("numarul: ");
            int index = Convert.ToInt32(Console.ReadLine());

            int valoareDupaSortare = ValoareDupaSortare(v1, index);

            Console.WriteLine($"Valoarea de pe pozitia {index} dupa sortare: {valoareDupaSortare}");
        }


        //Quicksort. Sortati un vector folosind metoda QuickSort. 
        static void QuickSort(int[] vector, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int pivotIndex = Partitie(vector, stanga, dreapta);

                QuickSort(vector, stanga, pivotIndex - 1);
                QuickSort(vector, pivotIndex + 1, dreapta);
            }
        }
        static int Partitie(int[] vector, int stanga, int dreapta)
        {
            int pivot = vector[dreapta];
            int i = stanga - 1;

            for (int j = stanga; j < dreapta; j++)
            {
                if (vector[j] <= pivot)
                {
                    i++;

                    int temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                }
            }

            int tempPivot = vector[i + 1];
            vector[i + 1] = vector[dreapta];
            vector[dreapta] = tempPivot;

            return i + 1;
        }
        private static void P28()
        {
            Console.Write("Introduceti vectorul: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');
            int[] vector = Array.ConvertAll(s1, int.Parse);

             Console.WriteLine("Vectorul initial: " + string.Join(", ", vector));

            QuickSort(vector, 0, vector.Length - 1);

            Console.WriteLine("Vectorul sortat: " + string.Join(", ", vector));
        }

        //MergeSort. Sortati un vector folosind metoda MergeSort.

        static void MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return; 

            int middle = array.Length / 2;

            int[] left = new int[middle];
            int[] right = new int[array.Length - middle];

            Array.Copy(array, 0, left, 0, middle);
            Array.Copy(array, middle, right, 0, array.Length - middle);

            MergeSort(left);
            MergeSort(right);

            Merge(array, left, right);
        }

        static void Merge(int[] array, int[] left, int[] right)
        {
            int leftIndex = 0, rightIndex = 0, mergedIndex = 0;
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    array[mergedIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[mergedIndex] = right[rightIndex];
                    rightIndex++;
                }

                mergedIndex++;
            }
            while (leftIndex < left.Length)
            {
                array[mergedIndex] = left[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < right.Length)
            {
                array[mergedIndex] = right[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }

        private static void P29()
        {
            Console.Write("Introduceti vectorul: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');
            int[] array = Array.ConvertAll(s1, int.Parse);

            Console.WriteLine("Original array: " + string.Join(", ", array));

            MergeSort(array);

            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }


        //Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar 
        //W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele 
        //lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, 
        //cea cu pondere mai mare va fi prima. 

        static void SortareBicriteriala(int[] E, int[] W)
        {
            if (E.Length != W.Length)
            {
                throw new ArgumentException("Vectorii E și W trebuie să aibă aceeași lungime.");
            }

            int n = E.Length;

            int[] indecsi = new int[n];
            for (int i = 0; i < n; i++)
            {
                indecsi[i] = i;
            }

            MergeSortBicriterial(E, W, indecsi, 0, n - 1);

            int[] WTemp = new int[n];
            for (int i = 0; i < n; i++)
            {
                WTemp[i] = W[indecsi[i]];
            }

            Array.Copy(WTemp, W, n);
        }

        static void MergeSortBicriterial(int[] E, int[] W, int[] indecsi, int stanga, int dreapta)
        {
            if (stanga < dreapta)
            {
                int mijloc = (stanga + dreapta) / 2;

                MergeSortBicriterial(E, W, indecsi, stanga, mijloc);
                MergeSortBicriterial(E, W, indecsi, mijloc + 1, dreapta);

                MergeBicriterial(E, W, indecsi, stanga, mijloc, dreapta);
            }
        }
        static void MergeBicriterial(int[] E, int[] W, int[] indecsi, int stanga, int mijloc, int dreapta)
        {
            int n1 = mijloc - stanga + 1;
            int n2 = dreapta - mijloc;

            int[] stangaE = new int[n1];
            int[] dreaptaE = new int[n2];
            int[] stangaW = new int[n1];
            int[] dreaptaW = new int[n2];
            int[] stangaIndecsi = new int[n1];
            int[] dreaptaIndecsi = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                stangaE[i] = E[stanga + i];
                stangaW[i] = W[stanga + i];
                stangaIndecsi[i] = indecsi[stanga + i];
            }

            for (int j = 0; j < n2; j++)
            {
                dreaptaE[j] = E[mijloc + 1 + j];
                dreaptaW[j] = W[mijloc + 1 + j];
                dreaptaIndecsi[j] = indecsi[mijloc + 1 + j];
            }

            int k = stanga;
            int leftIndex = 0, rightIndex = 0;

            while (leftIndex < n1 && rightIndex < n2)
            {
                if (stangaE[leftIndex] < dreaptaE[rightIndex] ||
                    (stangaE[leftIndex] == dreaptaE[rightIndex] && stangaW[leftIndex] >= dreaptaW[rightIndex]))
                {
                    E[k] = stangaE[leftIndex];
                    W[k] = stangaW[leftIndex];
                    indecsi[k] = stangaIndecsi[leftIndex];
                    leftIndex++;
                }
                else
                {
                    E[k] = dreaptaE[rightIndex];
                    W[k] = dreaptaW[rightIndex];
                    indecsi[k] = dreaptaIndecsi[rightIndex];
                    rightIndex++;
                }
                k++;
            }

            while (leftIndex < n1)
            {
                E[k] = stangaE[leftIndex];
                W[k] = stangaW[leftIndex];
                indecsi[k] = stangaIndecsi[leftIndex];
                leftIndex++;
                k++;
            }

            while (rightIndex < n2)
            {
                E[k] = dreaptaE[rightIndex];
                W[k] = dreaptaW[rightIndex];
                indecsi[k] = dreaptaIndecsi[rightIndex];
                rightIndex++;
                k++;
            }
        }

        private static void P30()
        {
            Console.Write("Introduceti vectorul 1: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');
            int[] E = Array.ConvertAll(s1, int.Parse);

            Console.Write("Introduceti vectorul 2: ");
            string input2 = Console.ReadLine();
            string[] s2 = input2.Split(' ');
            int[] W = Array.ConvertAll(s2, int.Parse);

            SortareBicriteriala(E, W);

            Console.WriteLine("Vectorul E sortat: " + string.Join(", ", E));
            Console.WriteLine("Vectorul W sortat: " + string.Join(", ", W));
        }

        //(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca 
        //mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are 
        //element majoritate acesta este unui singur).  
        //Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). 
        //(incercati sa gasiti o solutie liniara). 
        static int GasesteElementMajoritar(int[] vector)
        {
            int candidat = -1;
            int frecventa = 0;
            foreach (int numar in vector)
            {
                if (frecventa == 0)
                {
                    candidat = numar;
                    frecventa = 1;
                }
                else if (candidat == numar)
                {
                    frecventa++;
                }
                else
                {
                    frecventa--;
                }
            }

            frecventa = 0;
            foreach (int numar in vector)
            {
                if (candidat == numar)
                {
                    frecventa++;
                }
            }

            if (frecventa > vector.Length / 2)
            {
                return candidat;
            }

            return -1;
        }
        private static void P31()
        {
            Console.Write("Introduceti vectorul 1: ");
            string input = Console.ReadLine();
            string[] s1 = input.Split(' ');
            int[] vector = Array.ConvertAll(s1, int.Parse);


            int majoritar = GasesteElementMajoritar(vector);

            if (majoritar != -1)
            {
                Console.WriteLine($"Elementul majoritar este: {majoritar}");
            }
            else
            {
                Console.WriteLine("Nu există element majoritar în vector.");
            }
        }
    }
}