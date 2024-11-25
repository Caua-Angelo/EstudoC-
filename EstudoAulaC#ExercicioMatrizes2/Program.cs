namespace EstudoAulaC_ExercicioMatrizes2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre a quantidade de linhas"); 
            int linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a quantidade de Colunas");
            int colunas = int.Parse(Console.ReadLine());

            int[,]  mat =  new int[linhas, colunas];

            for (int i = 0; i < ; i++)

            Console.WriteLine("Entre o número que deve ser procurado na matriz");
            int numeromatriz = int.Parse(Console.ReadLine());
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    if (mat[i,j] == numeromatriz) {
                        Console.WriteLine("Position: " + i + j );

                    }
                }
            }
        }
    }
}
