using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace tema
{
    class Test {         
        static void Main(string[] args)
        {
            P21();
        }

        //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        private static void P1()
        {
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a != 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("Infinit");
                }
                else {
                    float x = -b / a;
                    Console.WriteLine(x);
                }
            }
            else{
                Console.WriteLine("Nu are solutie");
            }
        }

        //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
        private static void P2()
        {
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c= ");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a == 0 || b == 0 && c == 0) {
                Console.WriteLine("Ecuatia este nula");
                return;
            }
                
            double delta = Math.Pow(b, 2) - 4 * a * c;

            double x1 = 0, x2 = 0;

            if(delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta -1)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta -1)) / (2 * a);
            }
            if(delta == 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            if(delta < 0)
            {
                Console.WriteLine("ecuatia are solutii complexe");
                return;
            }
            Console.WriteLine(x1 + " " + x2);
        }

        //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
        private static void P3()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("k= ");
            int k = Convert.ToInt32(Console.ReadLine());

            if(n % k == 0)
            {
                Console.WriteLine("Se divide");
                return;
            }
            Console.WriteLine("Nu se divide");
        }

        //Detreminati daca un an y este an bisect. 
        private static void P4()
        {
            Console.Write("y= ");
            int y = Convert.ToInt32(Console.ReadLine());

            if(y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
            {
                Console.WriteLine("An bisect");
            }
            else
            {
                Console.WriteLine("An Nebisect");
            }
        }
        
        //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        private static void P5()
        {
            Console.Write("n= ");
            string n = Console.ReadLine();
            Console.Write("k= ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n[n.Length - k]);
        }

        //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        private static void P6()
        {
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c= ");
            int c = Convert.ToInt32(Console.ReadLine());
            
            if(a <= 0 || b <= 0 || c <= 0){
                Console.WriteLine("Laturele nu pot fi negative");
                return;
            }

            if(a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("a, b si c pot fi lungimile laturilor unui triunghi.");
                return;
            }

            Console.WriteLine("a, b si ce NU pot fi lungimile laturilor unui triunghi.");
        }

        //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
        private static void P7()
        {
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int b = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a={0}, b={1}", a ,b);
        }

        //Afisati toti divizorii numarului n. 
        private static void P8()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int contor = 1;
            for(int i = 1; i <= n / 2; i++)
            {
                if(n % i == 0)
                    contor++;
            }

            Console.WriteLine(contor);
        }

        //Afisati toti divizorii numarului n.
        private static void P9()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int contor = 2;
            for(int i = 2; i <= n / 2; i++)
            {
                if(n % i == 0)
                {
                    contor++;
                }
            }

            Console.WriteLine(contor);
        }

        //Test de primalitate: determinati daca un numar n este prim.
        private static void P10()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i < n / 2; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("Nu este numar prim");
                    return;
                }
            }
            Console.WriteLine("este numar prim");
        }

        //Afisati in ordine inversa cifrele unui numar n. 
        private static void P11()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int k = 0;
            while(n > 0)
            {
                k = k * 10 + n % 10;
                n /= 10;
            }

            Console.WriteLine(k);
        }

        //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
        private static void P12()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("intervalul nu poate exista");
                return;
            }
            
            int contor = 0;
            for(int i = a; i <= b; i++)
            {
                if(i % n == 0)
                {
                    contor++;
                }
            }
            Console.WriteLine(contor);
        }

        //Determianti cati ani bisecti sunt intre anii y1 si y2.
        private static void P13()
        {
            Console.Write("y1= ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2= ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int contor = 0;
            for(int y = y1; y <= y2; y++)
            {
                if((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0)) 
                {
                    contor++;
                    Console.WriteLine(y);
                }
            }
            Console.WriteLine(contor);
        }

        // Determianti daca un numar n este palindrom. 
        // (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 

        private static void P14()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int test = n;
            int verify = 0;
            while(test > 0)
            {
                verify *= 10;
                verify += test % 10;
                test = test / 10;
            }

            if(verify == n)
                Console.WriteLine("este palindrom");
            else
                Console.WriteLine("nu este palindrom");
        }

        //Se dau 3 numere. Sa se afiseze in ordine crescatoare.
        private static void P15()
        {
            Console.Write("n1= ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n2= ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n3= ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if(n1 > n2) (n1, n2) = (n2, n1);
            if(n2 > n3) (n2, n3) = (n3, n2);
            if(n1 > n2) (n1, n2) = (n2, n1);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }

        //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        private static void P16()
        {
            Console.Write("n1= ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n2= ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n3= ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n4= ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n5= ");
            int n5 = Convert.ToInt32(Console.ReadLine());

            if(n1 > n2) (n1, n2) = (n2, n1);
            if(n2 > n3) (n2, n3) = (n3, n2);
            if(n3 > n4) (n3, n4) = (n4, n3);
            if(n4 > n5) (n4, n5) = (n5, n4);

            if(n1 > n2) (n1, n2) = (n2, n1);
            if(n2 > n3) (n2, n3) = (n3, n2);
            if(n3 > n4) (n3, n4) = (n4, n3);

            if(n1 > n2) (n1, n2) = (n2, n1);
            if(n2 > n3) (n2, n3) = (n3, n2);

            if(n1 > n2) (n1, n2) = (n2, n1);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
        }

        // Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. 
        //Folositi algoritmul lui Euclid. 

        private static int CMMDC(int a, int b)
        {
            while(b > 0) {
                (a, b) = (b, a % b);
            }
            return a;
        }

        private static void P17()
        {
            Console.Write("n1= ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n2= ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int divcomun = CMMDC(n1, n2);
            int multiplu = Math.Abs(n1 * n2) / divcomun; 
            Console.WriteLine($"Cel mai mare divizor comun este {divcomun}");
            Console.WriteLine($"Cel mai mic multiplu comun este {multiplu}");
        }

        //Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 
        private static void P18()
        {
            Console.Write("n= ");
            int number = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, int> primeFactors = new Dictionary<int, int>();
            int divisor = 2;

            while (divisor <= number)
            {
                if (number % divisor == 0)
                {
                    if (primeFactors.ContainsKey(divisor))
                    {
                        primeFactors[divisor]++;
                    }
                    else
                    {
                        primeFactors[divisor] = 1;
                    }

                    number = number / divisor;
                }
                else
                {
                    divisor++;
                }
            }

            string result = "";
            foreach (var factor in primeFactors)
            {
                result += $"{factor.Key}^{factor.Value} ";
            }

            Console.WriteLine($"{result.Trim()}");
        }

        //Determinati daca un numar e format doar cu 2 cifre care se pot repeta. 
        //De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 

        private static bool DouaCifre(int numar)
        {
            var cifre = numar.ToString().Select(c => int.Parse(c.ToString())).ToList();
            return cifre.Distinct().ToList().Count == 2;
        }

        private static void P19()
        {
            Console.Write("n= ");
            int numar = Convert.ToInt32(Console.ReadLine());

            if(DouaCifre(numar))
                Console.WriteLine("Are Doua cifre repetate");
            else
                Console.WriteLine("Nu are doua cifre repetate");
        }

        // Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).
        // O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0
        // O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
        // O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. 

        static void Afisare(decimal fractie, List<int> perioada)
        {
            Console.Write($"{fractie}");

            if (perioada.Count <= 0)
                return;

            Console.Write("(");
            foreach (int n in perioada)
            {
                Console.Write(n);
            }
            Console.Write(")");
        }

        static string Clasificare(int numitor)
        {
            if (numitor == 1)
                return "neperiodică";
            else if (Perioada(numitor))
                return "periodică simplă";
            else if (Perioada(numitor) == false)
                return "periodică mixtă";
            else
                return "neperiodică";
        }

        static bool Perioada(int numitor)
        {
            while (numitor % 2 == 0)
                numitor /= 2;

            while (numitor % 5 == 0)
                numitor /= 5;

            return numitor == 1;
        }

        private static void P20()
        {
            Console.Write("m= ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            decimal fractie = (decimal)m / n;

            Console.WriteLine($"Fracția {m}/{n} este de tipul: {Clasificare(n)}");
            Afisare(fractie, new List<int> { 3 });
            Console.WriteLine();
        }

        //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

        private static void P21()
        {
            Console.WriteLine("Provocarea ta este sa ghicesti numarul cuprins intre 1 si 1024");
            int guest = 0;

            Random rnd = new Random();
            int numar = rnd.Next(1, 1024);

            while(guest != numar)
            {
                Console.Write("n= ");
                guest = Convert.ToInt32(Console.ReadLine());

                if(guest > numar)
                    Console.WriteLine("Numarul este mai mic");
                else
                    Console.WriteLine("Numarul este mai mare");
            }

            Console.WriteLine($"Bravo acesta este numarul {numar}");
        }
    }
}