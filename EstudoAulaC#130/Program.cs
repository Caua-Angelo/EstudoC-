namespace EstudoAulaC_130
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\caua.lopes\Documents/blabla.txt";

            string targetpath = @"C:\Users\caua.lopes\Documents/blabla2.txt";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcepath);
                fileinfo.CopyTo(targetpath);
                string[] lines = File.ReadAllLines(targetpath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);

                }
            }
            catch (IOException ex)
            {

                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);

            }

        }
    }
}