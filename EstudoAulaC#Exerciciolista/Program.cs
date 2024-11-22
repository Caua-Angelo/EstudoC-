namespace EstudoAulaC_Exerciciolista {

    internal class Program {
        static void Main(string[] args) {
            List<Funcionarios> listaFuncionarios = new List<Funcionarios>();
            Funcionarios Funcionario1 = new Funcionarios();
            Console.WriteLine("Quantos funcionários serão registrados?!");
            int QuantFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < QuantFuncionarios; i++) {
                Console.WriteLine("Funcionário #" + (1+ i));
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                listaFuncionarios.Add(new Funcionarios(id, name, salary));
                Console.WriteLine(listaFuncionarios);
            }
            Console.Write("Entre com o id do funcionário que deverá ter o salario aumentado");
            int IdAumentarsalario = int.Parse(Console.ReadLine());

            Funcionarios funcioID = listaFuncionarios.Find(x => x.Id == IdAumentarsalario);
            if (funcioID != null) {
                Console.WriteLine("Qual a porcentagem?: ");
                double PorcentagemAumento = double.Parse(Console.ReadLine());
                funcioID.AumentarSalario(PorcentagemAumento);
            }
            else {
                Console.WriteLine("Esse Id não está vinculado a nenhum funcionário");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionário");
            foreach (Funcionarios item in listaFuncionarios) {
                Console.WriteLine(item);
            }
        }
    }
}
