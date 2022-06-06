namespace uzduotis3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> face = new List<string>();
            face.Add("    ***************    ");
            face.Add("  **               **  ");
            face.Add(" **                 ** ");
            face.Add(" **     ()     ()   ** ");
            face.Add(" **         |       ** ");
            face.Add(" **         |       ** ");
            face.Add("  **    --------   **  ");
            face.Add("    ***************    ");

            foreach(string line in face)
            {
                Console.WriteLine(line);
            }

            foreach(string line in face)
            {
                Console.WriteLine(line.Replace('*', '"'));
            }
        }
    }
}