namespace switchPraktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World!");
            int pazymys = int.Parse(Console.ReadLine());

            if(pazymys >= 0 && pazymys <= 4)
            {
                Console.WriteLine("Nepatenkinamai");
            }
            else if(pazymys == 5)
            {
                Console.WriteLine("Silpnai");
            }
            else if(pazymys == 6)
            {
                Console.WriteLine("Patenkinamai");
            }
            else if (pazymys == 7)
            {
                Console.WriteLine("Vidutiniskai");
            }
            else if (pazymys == 8)
            {
                Console.WriteLine("Gerai");
            }
            else if (pazymys == 9)
            {
                Console.WriteLine("Labai gerai");
            }
            else if (pazymys == 10)
            {
                Console.WriteLine("Puikiai");
            }


            switch (pazymys)
            {
                case int i when i >= 0 && i < 5:
                    Console.WriteLine("Nepatenkinamas");
                    break;
                case 5:
                    Console.WriteLine("Silpnai");
                    break;
                case 6:
                    Console.WriteLine("Patenkinamai");
                    break;    
                case 7:
                    Console.WriteLine("Vidutiniskai");
                    break;
                case 8:
                    Console.WriteLine("Gerai");
                    break;
                case 9:
                    Console.WriteLine("Labai gerai");
                    break;
                case 10:
                    Console.WriteLine("Puikiai");
                    break;
            }

            Console.WriteLine(pazymys switch
            {
               0 or 1 or 2 or 3 or 4 => "Nepatenkinamas",
               5 => "Silpnai",
               6 => "Patenkinamai",
               7 => "Vidutiniskai",
               8 => "Gerai",
               9 => "Labai gerai",
               10 => "Puikiai",
               _ => null
            });
            */
            /*
            Console.WriteLine("Puodeliai: ");
            int kiek = int.Parse(Console.ReadLine());

            if (kiek > 2) 
            {
                Console.WriteLine("Nemokamas: {0}", kiek / 3);
            }
            else { Console.WriteLine("Nepriklauso"); }
            */
            /*
            Console.WriteLine("Nr1: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nr2: ");
            int sk2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nr3: ");
            int sk3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nr4: ");
            int sk4 = int.Parse(Console.ReadLine());
            
            if(sk1 == 0)
            {
                Console.WriteLine("Sk1: {0}", "N/A");
            }
            else Console.WriteLine("Sk1: {0}", sk1 * -1);

            if (sk2 == 0)
            {
                Console.WriteLine("Sk2: {0}", "N/A");
            }
            else Console.WriteLine("Sk2: {0}", sk2 * -1);

            if (sk3 == 0)
            {
                Console.WriteLine("Sk3: {0}", "N/A");
            }
            else Console.WriteLine("Sk3: {0}", sk3 * -1);

            if (sk4 == 0)
            {
                Console.WriteLine("Sk4: {0}", "N/A");
            }
            else Console.WriteLine("Sk4: {0}", sk4 * -1);
            */
            /*
            Console.WriteLine(sk1 == 0 ? "N/A" : sk1 * -1);
            Console.WriteLine(sk2 == 0 ? "N/A" : sk2 * -1);
            Console.WriteLine(sk3 == 0 ? "N/A" : sk3 * -1);
            Console.WriteLine(sk4 == 0 ? "N/A" : sk4 * -1);
            */
            /*
            int sk = 14;
            Console.WriteLine("Speti:");
            int sp1 = int.Parse(Console.ReadLine());

            if (sk == sp1)
            {
                Console.WriteLine("Atspejote.");
            }
            else
            {
                if (!(sp1 > 0 && sp1 < 20)) Console.WriteLine("Neteisingai ivestas skaiciu.");
                else Console.WriteLine(sp1 > sk ? "Skaicius yra mazesnis" : "Skaicius yra didesnis");

                int sp2 = int.Parse(Console.ReadLine());
                if (sk == sp2)
                {
                    Console.WriteLine("Atspejote.");
                }
                else
                {
                    if (!(sp2 > 0 && sp2 < 20)) Console.WriteLine("Neteisingai ivestas skaiciu.");
                    else Console.WriteLine(sp2 > sk ? "Skaicius yra mazesnis" : "Skaicius yra didesnis");

                    int sp3 = int.Parse(Console.ReadLine());
                    if (sk == sp3)
                    {
                        Console.WriteLine("Atspejote.");
                    }
                    else
                    {
                        if (!(sp3 > 0 && sp3 < 20)) Console.WriteLine("Neteisingai ivestas skaiciu.");
                        else Console.WriteLine(sp3 > sk ? "Skaicius yra mazesnis" : "Skaicius yra didesnis");

                        int sp4 = int.Parse(Console.ReadLine());
                        if (sk == sp4)
                        {
                            Console.WriteLine("Atspejote.");
                        }
                        else
                        {
                            if (!(sp4 > 0 && sp4 < 20)) Console.WriteLine("Neteisingai ivestas skaiciu.");
                            else Console.WriteLine(sp4 > sk ? "Skaicius yra mazesnis" : "Skaicius yra didesnis");

                            int sp5 = int.Parse(Console.ReadLine());
                            if (sk == sp5)
                            {
                                Console.WriteLine("Atspejote.");
                            }
                            else
                            {
                                if (!(sp5 > 0 && sp5 < 20)) Console.WriteLine("Neteisingai ivestas skaiciu.");
                                else Console.WriteLine(sp5 > sk ? "Skaicius yra mazesnis" : "Skaicius yra didesnis");
                                int sp6 = int.Parse(Console.ReadLine());
                                if (sk == sp6)
                                {
                                    Console.WriteLine("Atspejote.");
                                }
                                else
                                {
                                    Console.WriteLine("Neatspeta");
                                }
                            }
                        }
                    }
            
                }           
            }*/
            /*
            Console.WriteLine("Pirmas skaicius:");
            int sk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Antras skaicius:");
            int sk2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite operacija:");
            char op = char.Parse(Console.ReadLine());

            if (op == '+') Console.WriteLine(sk1 + sk2);
            else if (op == '-') Console.WriteLine(sk1 - sk2);
            else if (op == '*') Console.WriteLine(sk1 * sk2);
            else if (op == '/') Console.WriteLine((double)sk1 / sk2);

            switch (op)
            {
                case '+': Console.WriteLine(sk1 + sk2); break;
                case '-': Console.WriteLine(sk1 - sk2); break;
                case '*': Console.WriteLine(sk1 * sk2); break;
                case '/': Console.WriteLine((double)sk1 / sk2); break;
            }
            */
            /*
            Console.WriteLine("Pirmas draugas:");
            string name1 = Console.ReadLine();
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Antras draugas:");
            string name2 = Console.ReadLine();
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Trecias draugas:");
            string name3 = Console.ReadLine();
            int age3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Amziaus vidurkis: {0}", (double)(age1 + age2 + age3) / 3);

            if (age1 > age2 && age1 > age3)
            {
                Console.WriteLine($"Vyriausias: {name1}");
                Console.WriteLine(age2 < age3 ? $"Jauniausias: {name2}" : $"Jauniausias: {name3}");
            }                
            else if (age2 > age1 && age2 > age3)
            {
                Console.WriteLine($"Vyriausias: {name2}");
                Console.WriteLine(age1 < age3 ? $"Jauniausias: {name1}" : $"Jauniausias: {name3}");
            }
            else if (age3 > age1 && age3 > age2)
            {
                Console.WriteLine($"Vyriausias: {name3}");
                Console.WriteLine(age1 < age2 ? $"Jauniausias: {name1}" : $"Jauniausias: {name2}");
            }
            */

        }
    }
}