namespace EstudoAulaC_ExercicioEstruturaCondicional4 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre 2 valores");

            string[] valores = Console.ReadLine().Split(' ');
            int horainicial = int.Parse(valores[0]);
            int horafinal = int.Parse(valores[1]);


            int duracao = 0;
            if (horainicial < horafinal) { //Esse if verifica se a horainicial é menor que a horafinal. Ou seja, o caso em que o horário final ocorre no mesmo dia que o horário inicial. exemplo: Se a horainicial for 8 (8h da manhã) e a horafinal for 15 (3h da tarde), a duração será simplesmente a diferença entre as duas horas: 15 - 8 = 7.
                duracao = horafinal - horainicial;
            }
            else {
                duracao = 24 - horainicial + horafinal;
            }
            Console.WriteLine("O jogo durou: " + duracao + "Horas ");
        }
    }
}
