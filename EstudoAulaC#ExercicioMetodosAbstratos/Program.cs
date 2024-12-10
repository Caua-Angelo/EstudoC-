using EstudoAulaC_ExercicioMetodosAbstratos.Entities;
using EstudoAulaC_ExercicioMetodosAbstratos.Enums;

namespace EstudoAulaC_ExercicioMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of shapes: ");
            int numbershapes = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape>();
            for (int i = 1; i <= numbershapes; i++)
            {
                Console.Write("Shape #" + i + "Data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                string shape = Console.ReadLine();
                if (shape == "r" || shape == "R")
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width, height, color));
                }
                else if (shape == "C" || shape == "c")
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(color, radius));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("f2"));

            }
        }
    }
}