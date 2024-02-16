namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var domains = new Dictionary<string, string>()
            {
                {"est","Estonia"},
                {"lat","Latvia"},
                {"ba","Bgiosnia and herzegovina"},
                {"Rus","Russia"}

            };
            int i = 1;
            foreach (var domain in domains)
            {
                {
                    i++;
                    Console.WriteLine($"{domain.Key} - {domain.Value}");
                }
            }
        }
    }
}