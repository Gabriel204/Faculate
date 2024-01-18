using System;

namespace tema2
{
    class Test{
        static void Main(string[] args)
        {
            P16();
        }

        //Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 

        private static void P1()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sir = 0;
            int count = 0;

            for(int i = 0; i < n; i++)
            {
                Console.Write($"n{i + 1}= ");
                sir = Convert.ToInt32(Console.ReadLine());
                if(sir % 2 == 0)
                    count++;
            }

            Console.WriteLine($"Sunt {count} numere pare");
        }

        //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        private static void P2()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sir = 0;

            int negative = 0;
            int zero = 0;
            int pozitive = 0;

            for(int i = 0; i < n; i++)
            {
                Console.Write($"n{i + 1}= ");
                sir = Convert.ToInt32(Console.ReadLine());
                
                if(sir == 0)
                    zero++;
                if(sir < 0)
                    negative++;
                if(sir > 0)
                    pozitive++;
            }

            Console.WriteLine($"Sunt {negative} numere negative");
            Console.WriteLine($"Sunt {zero} numere de zero");
            Console.WriteLine($"Sunt {pozitive} numere pozitive");
        }

        //Calculati suma si produsul numerelor de la 1 la n. 
        private static void P3()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int suma = 0;
            double produsul = 1;

            for(int i = 1; i < n; i++)
            {
                suma += i;
                produsul *= i;
            }

            Console.WriteLine($"suma numerelor este {suma}");
            Console.WriteLine($"produsul numerelor este {produsul}");
        }

        //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
        //Se considera ca primul element din secventa este pe pozitia zero. 
        //Daca numarul nu se afla in secventa raspunsul va fi -1. 
        private static void P4()
        {
            Console.Write("Numarul dorit: ");
            int numarul = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numarul de elemente ");
            int n = Convert.ToInt32(Console.ReadLine());

            int index = -1;
            int num = 0;

            for(int i = 0; i < n; i++) {
                Console.Write($"n{i}= ");
                num = Convert.ToInt32(Console.ReadLine());

                if(numarul == num)
                    index = i;
            }

            Console.WriteLine(index);
        }

        //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
        //Se considera ca primul element din secventa este pe pozitia 0. 

        private static void P5()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            int num = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"N{i}= ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num == i)
                    count++;
            }

            Console.WriteLine($"{count} numere apar");
        }

        //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        private static void P6()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int num = 0;
            int oldnum = 0;

            bool crescatoare = true;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"N{i}= ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num < oldnum)
                    crescatoare = false;
                
                oldnum = num;
            }

            if(crescatoare) 
                Console.WriteLine("numerele sunt crescatoare");
            else 
                Console.WriteLine("numerele nu sunt crescatoare");
        }

        //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        private static void P7()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int max = 0;
            int min = Int32.MaxValue;

            int num = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"N{i}= ");
                num = Convert.ToInt32(Console.ReadLine());

                if(max < num)
                    max = num;
                if(min > num)
                    min = num;
            }

            Console.WriteLine($"cel mai mic numar este {min} si cel mai mare este {max}");
        }

        //Determianti al n-lea numar din sirul lui Fibonacci. 
        //Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). 
        //Exemplu: 0, 1, 1, 2, 3, 5, 8 .
        private static void P8()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            long f1 = 0;
            long f2 = 1;

            for(int i = 0; i < n; i++)
            {
                (f1, f2) = (f2, f1 + f2);
            }

            Console.WriteLine($"{f2}");
        }

        //Sa se determine daca o secventa de n numere este monotona.
        //Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 

        private static void P9()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int num = 0;
            int oldnum = 0;

            bool crescatoare = true;
            bool descrescatoare = false;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"N{i}= ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num < oldnum)
                    crescatoare = false;
                
                if(num > oldnum)
                    descrescatoare = true;
                
                oldnum = num;
            }

            if(crescatoare) 
                Console.WriteLine("numerele sunt monoton crescatoare");
            else if(descrescatoare)
                Console.WriteLine("numerele sunt monoton descrescatoare");
        }

        //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        private static void P10()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 1;
            int maxcount = 0;

            int num = 0;
            int firstnum = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"N{i}= ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num == firstnum)
                    count++;
                else
                {
                    firstnum = num;
                    count = 1;
                }
                
                if(count > maxcount)
                    maxcount = count;
            }

            Console.WriteLine($"{maxcount}");
        }

        //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.
        private static void P11()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int number = 0;
            double suma = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"n{i}= ");
                number = Convert.ToInt32(Console.ReadLine());
                suma = suma + (1 / number);
            }

            Console.WriteLine(suma);
        }

        //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        //Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
        //De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 

        private static void P12()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int num = 0;
            int count = 0;
            int last = 0;

            for(int i = 0; i < n; i++)
            {
                Console.Write($"N{i}= ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num != 0)
                {
                    if(last + 1 == num)
                        count++;
                    else
                        last = num;
                }
            }   

            Console.WriteLine(count);
        }

        //O <secventa crescatoare rotita> este o secventa de numere care este in ordine 
        //crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin 
        //rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre 
        //stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa 
        //crescatoare rotita. 
        private static void P13()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int minim = int.MaxValue;

            int primaValoare = int.Parse(Console.ReadLine());
            minim = primaValoare;

            for(int i = 1; i < n; i++)
            {
                int valoare = int.Parse(Console.ReadLine());

                if (valoare < minim)
                {
                    minim = valoare;
                }
            }

            for (int i = 1; i < n; i++)
            {
                int valoareActuala = int.Parse(Console.ReadLine());
                int valoareAnterioara = int.Parse(Console.ReadLine());

                if (valoareActuala < valoareAnterioara)
                {
                    Console.WriteLine("secventa nu este crescatoare nici dupa rotire");
                    return;
                }
            }

            Console.WriteLine("Secventa este crescatoare dupa rotire");
        }

        //O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata 
        //intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o 
        //secventa monotona rotita. 
        private static void P14()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int primaValoare = int.Parse(Console.ReadLine());
            int aDouaValoare = int.Parse(Console.ReadLine());

            bool esteCrescatoare = aDouaValoare > primaValoare;
            bool esteDescrescatoare = aDouaValoare < primaValoare;

            for (int i = 2; i < n; i++)
            {
                int valoare = int.Parse(Console.ReadLine());

                if (esteCrescatoare && valoare < aDouaValoare)
                {
                    esteCrescatoare = false;
                }
                else if (esteDescrescatoare && valoare > aDouaValoare)
                {
                    esteDescrescatoare = false;
                }

                aDouaValoare = valoare;
            }

            if(esteCrescatoare || esteDescrescatoare)
                Console.WriteLine("Secvența este o secvență monotonă rotită.");
            else 
                Console.WriteLine("Secvența nu este o secvență monotonă rotită.");
        }

        //O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton 
        //descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se 
        //determine daca este bitonica. 
        private static void P15()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("n1= ");
            int num = Convert.ToInt32(Console.ReadLine());
            int lastnum = num;

            bool crescator = false;
            bool descrecator = false;

            for(int i = 1; i < n; i++)
            {
                Console.Write($"n{i+1}= ");
                num = Convert.ToInt32(Console.ReadLine());
                if(lastnum < num)
                    crescator = true;
                
                if(lastnum > num)
                    descrecator = true;

                lastnum = num;
            }

            if(crescator == true && descrecator == true)
                Console.WriteLine("Sirul este bitonic");
            else
                Console.WriteLine("Sirul nu este bitonic");
        }

        //O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata 
        //intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). 
        //Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
        private static void P16()
        {
            Console.WriteLine("Introduceți secvența de numere separate prin spațiu:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) {
                Console.WriteLine("Secvența este vidă sau null. Introduceți o secvență validă.");
                return;
            }

            bool isrotate = IsRotate(input);

            if (isrotate)
                Console.WriteLine("Secvența este o secvență bitonică rotită.");
            else
                Console.WriteLine("Secvența NU este o secvență bitonică rotită.");
        }

        private static bool IsRotate(string sir)
        {
            int n = sir.Length;
            int maxIndex = 0;

            for (int i = 1; i < n; i++) {
                if (sir[i] > sir[maxIndex])
                    maxIndex = i;
            }

            for (int i = 1; i < maxIndex; i++)  {
                if (sir[i] <= sir[i - 1])
                    return false;
            }

            for (int i = maxIndex + 1; i < n; i++)  {
                if (sir[i] >= sir[i - 1])
                    return false;
            }

            return true;
        }

        //Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. 
        //Determinati daca secventa reprezinta o secventa de paranteze corecta si,  
        //daca este, determinati nivelul maxim de incuibare a parantezelor. 
        //De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe 
        //cand 0 0 1 1 1 0 este incorecta.
        private static void P17()
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            int pdeschisa = 0;
            int pinchisa = 0;

            int num = 0;

            for(int i = 0; i < n; i++)
            {  
                Console.Write($"n{i + 1}= ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num == 0)
                    pdeschisa++;
                if(num == 1)
                    pinchisa++;
            }

            if(pdeschisa == pinchisa && pdeschisa % 2 == 0 && pinchisa % 2 == 0)
                Console.WriteLine("Sirul este correct");
            else
                Console.WriteLine("Sirul nu este correct");
        }
    }
}