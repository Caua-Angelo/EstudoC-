namespace EstudoAulaC_69 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantidade de pessoas?");
            Console.WriteLine("Entre com o valor delas");

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];//cria um vetor e o inicia com a quantidade de "espaços" equivalente ao valor de n

            for (int i = 0; i < n; i++) {//preenche com um valor em double a quantidade de "espaços"vazios do vetor vect
                vect[i] = double.Parse(Console.ReadLine());
            }
            double sum = 0.0;//cria uma variável para receber o valor da soma dos valores armazenados no vetor vect
            for (int i = 0; i < n; i++) {//faz o valor de sum receber cada um dos valores armazenados no vetor vect
                sum += vect[i];
            }
            double avg = sum / n;

            Console.WriteLine("A altura media é = " + avg.ToString("f2"));
        }
    }
}
