namespace EstudoAulaC_ExercicioMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of shapes: ");
            int numbershapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbershapes; i++)
            {
                Console.Write("Shape #"+i+ "Data:" );
                Console.Write("Rectangle or Circle (r/c)? ");
                string shape = Console.ReadLine();
                if (shape == "r" || shape == "R")
                {

                }
                else if(shape == "C" || shape == "c")
                {


                }

            }
        }
    }
}