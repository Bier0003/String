namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddSeparate());
            Console.WriteLine();
        }






        static string AddSparator(string names)
        {
            foreach( string name in names) {
                string newNAme = name.Replace("", "^");
                return newNAme;
            }

        }












    }
}