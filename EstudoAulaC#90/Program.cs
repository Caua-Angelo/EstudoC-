namespace EstudoAulaC_90 {
    internal class Program {
        static void Main(string[] args) {

            TimeSpan d1 = TimeSpan.FromDays(1.5);
            TimeSpan d2 = TimeSpan.FromHours(1.5);
            TimeSpan d3 = TimeSpan.FromMinutes(1.5);
            TimeSpan d4 = TimeSpan.FromSeconds(1.5);
            TimeSpan d5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan d6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);


            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000);
            TimeSpan t3 = new TimeSpan(2,11,21);
            TimeSpan t4 = new TimeSpan(1,2,11,21);
            TimeSpan t5 = new TimeSpan(1,2,11,21,321);

            Console.WriteLine();
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
        }
    }
}
