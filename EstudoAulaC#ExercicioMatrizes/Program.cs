namespace EstudoAulaC_ExercicioMatrizes {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o tamanho da matriz");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];//cria uma matriz e define que ela tem o tamanho n e n de linhas e colunas 

            for (int i = 0; i < n; i++) {//percorre as linhas da matriz

                string[] values = Console.ReadLine().Split(' ');//recebe os valores em string reparte eles dentro de um vetor de string
                for (int j = 0; j < n; j++) {//percorre as colunas da matriz
                    mat[i, j] = int.Parse(values[j]); //os campos i e j da matriz vão receber os valors armazenados no vetor values
                }
            }
            Console.WriteLine("Main diagonal: ");//mostra os valores na diagonal principal
            for (int i = 0; i < n; i++) {//percorre as linhas da matriz
                Console.Write(mat[i, i] + " ");//mostra a linha e a coluna da matriz equivalente a "i"
            }
            Console.WriteLine();

            int count = 0;//cria uma variável para ser o contador de números negativos dentro da matriz
            for (int i = 0; i < n; i++) {//percorre a linhas da matriz
                for (int j = 0; j < n; j++) {//percorre as colunas da matriz
                    if (mat[i, j] < 0) {//verifica se os números percorridos nas linhas e colunas são negativos
                        count++; //se forem negativos o valor de count aumenta
                    }
                }
            }
                    Console.WriteLine("Negatives numbers: " + count); //expõe o valor de números negativos
        }
    }
}
