namespace EstudoAulaC_89 {
    internal class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2024,11,26);
            DateTime d2 = new DateTime(2024,11,26,13,38,3);
            DateTime d3 = new DateTime(2024,11,26,13,38,3,500);


            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2.Ticks);
        }
    }
}
