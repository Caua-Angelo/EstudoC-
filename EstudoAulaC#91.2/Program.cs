namespace EstudoAulaC_91._2 {
    internal class Program {
        static void Main(string[] args) {

            DateTime d = DateTime.Now;

            DateTime d2 = d.AddDays(7);

            DateTime d3 = d.AddMinutes(3);

            TimeSpan t = d.Subtract(d2);



            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

        }
    }
}
