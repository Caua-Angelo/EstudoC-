namespace EstudoAulaC_70 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("qual a quantidade de produtos?");

            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();//le o valor de nome em string
                double price = double.Parse(Console.ReadLine());//le o valor de price em double
                vect[i] = new Produto { Name = name, Price = price };//inicia
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
                
            }
            double avg = sum / n;
            Console.WriteLine("Average price = " + avg.ToString("F2"));
        }
    }
}