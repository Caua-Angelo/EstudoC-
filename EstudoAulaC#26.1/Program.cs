namespace EstudoAulaC_26 {
    internal class Program {
        static void Main(string[] args) {
            int a = 10;
            bool c1 = a < 10;//F
            bool c2 = a < 20;//T
            bool c3 = a > 10;//F
            bool c4 = a > 5;//T
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("------------");
            bool c5 = a <= 10;//T
            bool c6 = a >= 10;//T
            bool c7 = a == 10;//T
            bool c8 = a != 10;//F
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
        }
    }
}
