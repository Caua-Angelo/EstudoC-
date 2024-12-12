namespace EstudoAulaC_134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\caua.lopes\Documents";
            Console.WriteLine("Hello, World!");
            try
            {
                Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
            }
        }
    }
}