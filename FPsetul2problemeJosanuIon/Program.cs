using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FPsetul2problemeJosanuIon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buna ziua si va multumesc pentru atentie!\n\n" +
              "Ma numesc Josanu Ion, student anul I la Facutlatea de Informatica si Stiinte a Univsersitatii din Oradea, specializarea Informatica.\n\n" +
              "Acesta este al doilea set de probleme rezolvate la disciplina Fundamentele Programarii.\n\n" +
              "Va rog sa introduceti numarul problemei(1-17) pentru verificare :");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("Conditia : Se da o secventa de n numere. Sa se determine cate din ele sunt pare. "); P1(); break;
                case 2: Console.WriteLine("Conditia : Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive."); P2(); break;
                case 3: Console.WriteLine("Conditia : Calculati suma si produsul numerelor de la 1 la n. "); P3(); break;
                case 4: Console.WriteLine("Conditia : Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.\n" +
                    "Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. "); P4(); break;
                case 5: Console.WriteLine("Conditia : Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.\nSe considera ca primul element din secventa este pe pozitia 0. "); P5(); break;
                case 6: Console.WriteLine("Conditia : Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. "); P6(); break;
                case 7: Console.WriteLine("Conditia : Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. "); P7(); break;
                case 8: Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ..."); P8(); break;
                case 9: Console.WriteLine("Conditia : Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. "); P9(); break;
                case 10: Console.WriteLine("Conditia : Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. "); P10(); break;
                case 11: Console.WriteLine("Conditia : Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. "); P11(); break;
                case 12: Console.WriteLine("Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, " +
                    "zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. "); P12(); break;


                default: Console.WriteLine("Ati introdus un numar care nu este de la 1 la 17 sau aceasta problema inca nu a fost rezolvata.)"); Console.ReadKey(); break;
            }
        }

        private static void P12()
        {
            Console.Write("Introducenti n :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementelele secventei, unul cate unul, din rand nou :");
            int counter = 1;
            int precedent = int.Parse(Console.ReadLine());
            int grupuri = 0;
            while (counter!=n)
            {
                int element = int.Parse(Console.ReadLine());
                if (precedent!=0 && element==0)
                {
                    grupuri++;
                }
                if ((counter==n-1)&&element!=0)
                {
                    grupuri++;
                }
                precedent = element;
                counter++;
            }
            Console.WriteLine("Numarul de grupuri este : "+grupuri);

            Console.ReadKey();
        }

    

    private static void P11()
        {
            Console.Write("Introducenti n :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementelele secventei, unul cate unul, din rand nou :");
            double suminv = 0;
            int counter = 0;
            while(counter!=n)
            {
                double local = double.Parse(Console.ReadLine()); ;
                if (local==0)
                {
                    suminv = suminv + 0;
                }
                else
                {
                    suminv = suminv + (1/local);
                }
                counter++;
            }
            Console.WriteLine("Suma inverselor este : {0}", suminv);
            Console.ReadKey();
        }

        private static void P10()
        {
            Console.Write("Introducenti n :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementelele secventei, unul cate unul, din rand nou :");
            int counter = 1;
            int precedent = int.Parse(Console.ReadLine());
            int consecutive = 1;
            int maxconsecutive = 0;

            while (counter!=n)
            {
                int element = int.Parse(Console.ReadLine());
                if (precedent==element)
                {
                    consecutive++;
                }
                else
                {
                    consecutive = 1;
                }
                if (consecutive>maxconsecutive)
                {
                    maxconsecutive = consecutive;
                }
                precedent = element;
                counter++;
            }


            Console.WriteLine("Numarul maxim de numere consecutive egale din secventa este : {0}", maxconsecutive);
            Console.ReadKey();
        }

        private static void P9()
        {
            Console.Write("Introducenti n :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementelele secventei, unul cate unul, din rand nou :");
            int counter = 1;
            bool NuCrescatoare = false;
            bool NuDescrescatoare = false;
            int precedent = int.Parse(Console.ReadLine());
            
            while (counter!=n)
            {
                int element = int.Parse(Console.ReadLine());
                if (precedent>element)
                {
                    NuCrescatoare = true;//descrescatoare
                }
                if (precedent<element)
                {
                    NuDescrescatoare = true;//crescatoare
                }
                precedent = element;
                counter++;
            }

            if (NuDescrescatoare && !NuCrescatoare)
            {
                Console.WriteLine("Secventa este monoton crescatoare");
            }
            if (!NuDescrescatoare && NuCrescatoare)
            {
                Console.WriteLine("Secventa este monoton descrescatoare");
            }
            if (NuDescrescatoare && NuCrescatoare)
            {
                Console.WriteLine("Secventa nu este monotona");
            }

            Console.ReadKey();
        }

        private static void P8()
        {
            
            Console.Write("Introduceti n : "); 
            int n =int.Parse(Console.ReadLine());
            int x1 = 0, x2 = 1, Fib = 0;
            for (int i = 1; i <n-1 ; i++)
            {
                Fib = x2 + x1;
                x1 = x2;
                x2 = Fib;
            }
            if (n==1)
            {
                Console.WriteLine("Primul termen al sirului Fibonacci este : {0}",0);
            }
            if (n == 2)
            {
                Console.WriteLine("Al doilea termen al sirului Fibonacci este : {0}",1);
            }
            if (n>2)
            {
                Console.WriteLine("Elementul cu numarul n={0} este : {1}",n, Fib);
            }
            Console.ReadKey();
        }

        private static void P7()
        {
            Console.Write("Introducenti n :");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementelele secventei, unul cate unul, din rand nou :");
            
            int counter=1;
            int element = int.Parse(Console.ReadLine());
            int minim = element;
           int  maxim = element;
            while (counter!=n)
            {
                element = int.Parse(Console.ReadLine());
                if (element>maxim)
                {
                    maxim = element;
                }
                if (element<minim)
                {
                    minim = element;
                }
                counter++;

            }
                Console.WriteLine("Cea mai mica valoare este : {0}",minim);
                Console.WriteLine("Cea mai mare valoare este : {0}", maxim);
            Console.ReadKey();
        }

        private static void P6()
        {
            Console.Write("Introducenti n :");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementelele secventei, unul cate unul, din rand nou :");

            bool NuCrescatoare = false;
            int counter = 1;
            int precedent = int.Parse(Console.ReadLine());
            while (counter!=n)
            {
                int local = int.Parse(Console.ReadLine());
            
                if (precedent>local)
                {
                    NuCrescatoare = true;
                }
                precedent = local;
                counter++;
            }
           
            if(NuCrescatoare)
            {
                Console.WriteLine("Numerele nu sunt aranjate in ordine crescatoare");
            }
            else
            {
                Console.WriteLine("Numerele din secventa introdusa sunt aranjate in ordine crescatoare");
            }
            Console.ReadKey();
        }

        private static void P5()
        {
            Console.Write("Introducenti n :");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementelele secventei, unul cate unul, din rand nou :");
            int counter = 0;
            int NrEgaleCuPozitia = 0;
            while (counter != n)
            {
                int element = int.Parse(Console.ReadLine());
                if (counter == element)
                {
                    NrEgaleCuPozitia++;
                }
                counter++;
            }
            Console.WriteLine("In secventa de {0} numere sunt {1} elemente egale cu pozitia pe care sunt.",n, NrEgaleCuPozitia );
            Console.ReadKey();

        }

        private static void P4()
        {
            Console.Write("Introducenti n :"); 
            int n = int.Parse(Console.ReadLine());
             
            Console.Write("Introducenti nuamrul a :"); 
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementelele secventei, unul cate unul, din rand nou :");
            int counter = 0;
            int pozitia = -1;
            while (counter!=n)
            {
                int element = int.Parse(Console.ReadLine());
                if (a==element)
                {
                    pozitia = counter;
                }
                counter++;
            }
            Console.WriteLine("Pozitia numarului {0} este : {1}",a, pozitia);
            Console.ReadKey();
        }

        private static void P3()
        {
            Console.Write("Introducenti n :"); 
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int produsul = 1;
            for (int i = 1; i <=n; i++)
            {
                suma = suma + i;
            }
            for (int i = 1; i <= n; i++)
            {
                produsul = produsul * i;
            }
            Console.WriteLine("Suma numerelor de la 1 la {0} este egala cu {1}",n,suma);
            Console.WriteLine("Produsul numerelor de la 1 la {0} este egal cu {1}", n, produsul);
            Console.ReadKey();
        }

        private static void P2()
        {
            Console.Write("Introducenti n :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti elementelele secventei, unul cate unul, din rand nou :");
            
            int poz = 0;
            int zero = 0;
            int neg = 0;
            int counter = 0;
           while(counter!=n)
            {
                int element = int.Parse(Console.ReadLine());
                if (element > 0)
                {
                    poz++;
                }
                else if (element == 0)
                {
                    zero++;
                }
                else if (element<0)
                {
                    neg++;
                }
                counter++;
            }
            Console.WriteLine("In secventa sunt:\n{0} numere pozitive\n{1} numere egale cu zero\n{2} numere negative",poz, zero, neg);
            Console.ReadKey();
        }

        private static void P1()
        {
            int  counter= 0;//folosit pentru a citi exact n elemente
            int element;
            int EstePar = 0;
            Console.Write("Introducenti n :"); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti elementelele secventei, unul cate unul, din rand nou :");
            while (counter!=n)
            {
                element = int.Parse(Console.ReadLine());
                if (element%2==0)
                {
                    EstePar++;
                }
                counter++;
            }
            Console.WriteLine("numere pare sunt "+EstePar);
            Console.ReadKey();
        }
    }
}
