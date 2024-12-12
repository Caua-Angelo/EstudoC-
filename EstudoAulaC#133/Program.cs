namespace EstudoAulaC_133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\caua.lopes\Documents/blabla.txt";
            string targetpath = @"C:\Users\caua.lopes\Documents/blabla2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);
                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);

                throw;
            }




        }
    }
}
