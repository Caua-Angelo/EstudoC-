namespace EstudoAulaC_132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\caua.lopes\Documents/blabla.txt";
            try
            {


                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }


        }
    }
}