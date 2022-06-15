namespace loginiai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Iveskite pirma skaiciu:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(number2 == number1);
            */
            /*
            Console.WriteLine("Iveskite pirma skaiciu:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(number2 % 2 == 0 && number1 % 2 == 0);
            */
            /*
            string kanalasA = "__---___---___---___---___";
            string kanalasB = "____---___---___---___---_";

            string atsA = "";
            string atsB = "";
            string atsC = "";
            string atsD = ""; 
            string atsE = "";
            string atsF = "";
            string atsG = "";
            string atsH = "";

            for (int i = 0; i < kanalasA.Length; i++)
            {
                if (kanalasA[i] == '-' && kanalasB[i] == '-')
                {
                    atsA = atsA + '-';
                }
                else { atsA = atsA + '_'; }

                if (kanalasA[i] == '-' || kanalasB[i] == '-')
                {
                    atsB = atsB + '-';
                }
                else { atsB = atsB + '_'; }

                if (kanalasA[i] == '-' ^ kanalasB[i] == '-')
                {
                    atsC = atsC + '-';
                }
                else { atsC = atsC + '_'; }

                if (!(kanalasA[i] == '-' && kanalasB[i] == '-'))
                {
                    atsD = atsD + '-';
                }
                else { atsD = atsD + '_'; }

                if (!(kanalasA[i] == '-' || kanalasB[i] == '-'))
                {
                    atsE = atsE + '-';
                }
                else { atsE = atsE + '_'; }

                if (!(kanalasA[i] == '-'))
                {
                    atsF = atsF + '-';
                }
                else { atsF = atsF + '_'; }

                if (!(kanalasA[i] == '-') || kanalasB[i] == '-')
                {
                    atsG = atsG + '-';
                }
                else { atsG = atsG + '_'; }

                if (!((kanalasA[i] == '-' || kanalasB[i] == '-') && kanalasA[i] == '-'))
                {
                    atsH = atsH + '-';
                }
                else { atsH = atsH + '_'; }
            }


            Console.WriteLine(atsA);
            Console.WriteLine(atsB);
            Console.WriteLine(atsC);
            Console.WriteLine(atsD);
            Console.WriteLine(atsE);
            Console.WriteLine(atsF);
            Console.WriteLine(atsG);
            Console.WriteLine(atsH);
            */

            Console.WriteLine(false || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);

            Console.WriteLine(!false || false);
            Console.WriteLine(!false || true);
            Console.WriteLine(!true || false);
            Console.WriteLine(!true || true);


            Console.WriteLine();
        }
    }
}