namespace EstudoAula20C_ {
    internal class Program {
        static void Main(string[] args) {

            float x = 4.5F;
            Double y = x;
            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            b = (float)a; //informa que pode jogar um conteudo de 8 bytes em uma variável que só suporta 4 bytes,nesse caso b pode receber a forçadamente
            Console.WriteLine(b);

            double f;
            int l;

            f = 5.1;
            l = (int)f;// nesse tipo de conversão os valores depois da virgula serão ignorados gerando assim,perda de informação
            Console.WriteLine(l);
                
        }
    }
}
