namespace EstudoAulaC_79 {
    internal class Program {
        static void Main(string[] args) {

            double[,] mat = new double[2, 3];//inicia uma matriz( é necessário ter uma , dentro das chaves) e diz que ela tem 2 linhas e 3 colunas

            Console.WriteLine(mat.Length);//diz a quantidade de valores que a matriz consegue guardar,nesse caso é calculado as 2x3,as linhas x colunas

            Console.WriteLine(mat.Rank);//diz quanto é a primeira dimensão da matriz,nesse caso a quantidade de linhas

            Console.WriteLine(mat.GetLength(0));//diz que  qual o tamanho que tem a primeira dimensão da matriz,nesse caso (2)Linhas

            Console.WriteLine(mat.GetLength(0));//diz que  qual o tamanho que tem a segunda dimensão da matriz,nesse caso (3)colunas
        }
    }
}
