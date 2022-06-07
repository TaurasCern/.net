namespace savarankiskas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string noRing =      "      |      ";
            string smallRing =   "     #|#     ";
            string mediumRing =  "    ##|##    ";
            string largeRing =   "   ###|###   ";
            string largestRing = "  ####|####  ";

            string col1row1 = noRing;
            string col1row2 = noRing;
            string col1row3 = noRing;
            string col1row4 = noRing;
            string col1row5 = noRing;
            string col2row1 = noRing;
            string col2row2 = noRing;
            string col2row3 = noRing;
            string col2row4 = noRing;
            string col2row5 = noRing;
            string col3row1 = noRing;
            string col3row2 = noRing;
            string col3row3 = noRing;
            string col3row4 = noRing;
            string col3row5 = noRing;

            Console.WriteLine("Tower of Hanoi");

            col1row2 = smallRing;
            col1row3 = mediumRing;
            col1row4 = largeRing;
            col1row5 = largestRing;

            Console.WriteLine("Pirmas punktas");
            Console.WriteLine("1eil. {0}{1}{2}", col1row1,  col2row1,  col3row1);
            Console.WriteLine("2eil. {0}{1}{2}", col1row2,  col2row2,  col3row2);
            Console.WriteLine("3eil. {0}{1}{2}", col1row3,  col2row3,  col3row3);
            Console.WriteLine("4eil. {0}{1}{2}", col1row4,  col2row4,  col3row4);
            Console.WriteLine("5eil. {0}{1}{2}", col1row5,  col2row5,  col3row5);
            Console.WriteLine("       ----1st----------2st----------3st----");

            Console.WriteLine("testi");
            Console.ReadKey();
            Console.WriteLine();

            col1row1 = largestRing;
            col1row2 = largeRing;
            col1row3 = mediumRing;
            col1row4 = smallRing;
            col1row5 = noRing; 

            Console.WriteLine("Antras punktas");
            Console.WriteLine("1eil. {0}{1}{2}", col1row1, col2row1, col3row1);
            Console.WriteLine("2eil. {0}{1}{2}", col1row2, col2row2, col3row2);
            Console.WriteLine("3eil. {0}{1}{2}", col1row3, col2row3, col3row3);
            Console.WriteLine("4eil. {0}{1}{2}", col1row4, col2row4, col3row4);
            Console.WriteLine("5eil. {0}{1}{2}", col1row5, col2row5, col3row5);
            Console.WriteLine("       ----1st----------2st----------3st----");

            Console.WriteLine("testi");
            Console.ReadKey();
            Console.WriteLine();

            col1row1 = noRing;
            col1row2 = noRing;
            col1row3 = noRing;
            col1row4 = noRing;
            col1row5 = noRing;

            Console.WriteLine("Trecias punktas");
            Console.WriteLine("1eil. {0}{1}{2}", col1row1, col2row1, col3row1);
            Console.WriteLine("2eil. {0}{1}{2}", col1row2, col2row2, col3row2);
            Console.WriteLine("3eil. {0}{1}{2}", col1row3, col2row3, col3row3);
            Console.WriteLine("4eil. {0}{1}{2}", col1row4, col2row4, col3row4);
            Console.WriteLine("5eil. {0}{1}{2}", col1row5, col2row5, col3row5);
            Console.WriteLine("       ----1st----------2st----------3st----");

            Console.WriteLine("testi");
            Console.ReadKey();
            Console.WriteLine();

            col1row5 = largestRing;
            col2row5 = largestRing;
            col3row5 = largestRing;

            Console.WriteLine("Ketvirtas punktas");
            Console.WriteLine("1eil. {0}{1}{2}", col1row1, col2row1, col3row1);
            Console.WriteLine("2eil. {0}{1}{2}", col1row2, col2row2, col3row2);
            Console.WriteLine("3eil. {0}{1}{2}", col1row3, col2row3, col3row3);
            Console.WriteLine("4eil. {0}{1}{2}", col1row4, col2row4, col3row4);
            Console.WriteLine("5eil. {0}{1}{2}", col1row5, col2row5, col3row5);
            Console.WriteLine("       ----1st----------2st----------3st----");

            Console.WriteLine("testi");
            Console.ReadKey();
            Console.WriteLine();

            col1row5 = largestRing;
            col2row5 = mediumRing;
            col3row4 = smallRing;
            col3row5 = largeRing;

            Console.WriteLine("Penktas punktas");
            Console.WriteLine("1eil. {0}{1}{2}", col1row1, col2row1, col3row1);
            Console.WriteLine("2eil. {0}{1}{2}", col1row2, col2row2, col3row2);
            Console.WriteLine("3eil. {0}{1}{2}", col1row3, col2row3, col3row3);
            Console.WriteLine("4eil. {0}{1}{2}", col1row4, col2row4, col3row4);
            Console.WriteLine("5eil. {0}{1}{2}", col1row5, col2row5, col3row5);
            Console.WriteLine("       ----1st----------2st----------3st----");

            Console.WriteLine("testi");
            Console.ReadKey();
            Console.WriteLine();

            col1row4 = col3row4;

            Console.WriteLine("Sestas punktas");
            Console.WriteLine("1eil. {0}{1}{2}", col1row1, col2row1, col3row1);
            Console.WriteLine("2eil. {0}{1}{2}", col1row2, col2row2, col3row2);
            Console.WriteLine("3eil. {0}{1}{2}", col1row3, col2row3, col3row3);
            Console.WriteLine("4eil. {0}{1}{2}", col1row4, col2row4, col3row4);
            Console.WriteLine("5eil. {0}{1}{2}", col1row5, col2row5, col3row5);
            Console.WriteLine("       ----1st----------2st----------3st----");

            Console.WriteLine("testi");
            Console.ReadKey();
            Console.WriteLine();

            col2row1 = largeRing;
            col2row2 = largeRing;
            col2row3 = largeRing;
            col2row4 = largeRing;
            col2row5 = largeRing;

            Console.WriteLine("Septintas punktas");
            Console.WriteLine("1eil. {0}{1}{2}", col1row1, col2row1, col3row1);
            Console.WriteLine("2eil. {0}{1}{2}", col1row2, col2row2, col3row2);
            Console.WriteLine("3eil. {0}{1}{2}", col1row3, col2row3, col3row3);
            Console.WriteLine("4eil. {0}{1}{2}", col1row4, col2row4, col3row4);
            Console.WriteLine("5eil. {0}{1}{2}", col1row5, col2row5, col3row5);
            Console.WriteLine("       ----1st----------2st----------3st----");

            Console.WriteLine("testi");
            Console.ReadKey();
            Console.WriteLine();

            col1row4 = noRing;
            col1row5 = noRing;
            col2row1 = noRing;
            col2row2 = noRing;
            col2row3 = noRing;
            col2row4 = noRing;
            col2row5 = noRing;
            col3row2 = smallRing;
            col3row3 = mediumRing;
            col3row4 = largeRing;
            col3row5 = largestRing;

            Console.WriteLine("Astuntas punktas");
            Console.WriteLine("1eil. {0}{1}{2}", col1row1, col2row1, col3row1);
            Console.WriteLine("2eil. {0}{1}{2}", col1row2, col2row2, col3row2);
            Console.WriteLine("3eil. {0}{1}{2}", col1row3, col2row3, col3row3);
            Console.WriteLine("4eil. {0}{1}{2}", col1row4, col2row4, col3row4);
            Console.WriteLine("5eil. {0}{1}{2}", col1row5, col2row5, col3row5);
            Console.WriteLine("       ----1st----------2st----------3st----");

            Console.WriteLine("testi");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Devintas punktas");
            Console.WriteLine("1eil. {0}{1}{2}", col1row1, col2row1, col3row1);
            Console.WriteLine("2eil. {0}{1}{2}", col1row2, col2row2, col3row2.Replace('#','"'));
            Console.WriteLine("3eil. {0}{1}{2}", col1row3, col2row3, col3row3.Replace('#', '"'));
            Console.WriteLine("4eil. {0}{1}{2}", col1row4, col2row4, col3row4.Replace('#', '"'));
            Console.WriteLine("5eil. {0}{1}{2}", col1row5, col2row5, col3row5.Replace('#', '"'));
            Console.WriteLine("       ----1st----------2st----------3st----");

            Console.WriteLine("testi");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Nupieskite zieda(13 simboliu):");
            col1row5 = Console.ReadLine();
            Console.WriteLine("Desimtas punktas");
            Console.WriteLine("1eil. {0}{1}{2}", col1row1, col2row1, col3row1);
            Console.WriteLine("2eil. {0}{1}{2}", col1row2, col2row2, col3row2);
            Console.WriteLine("3eil. {0}{1}{2}", col1row3, col2row3, col3row3);
            Console.WriteLine("4eil. {0}{1}{2}", col1row4, col2row4, col3row4);
            Console.WriteLine("5eil. {0}{1}{2}", col1row5, col2row5, col3row5);
            Console.WriteLine("       ----1st----------2st----------3st----");

            Console.WriteLine("testi");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}