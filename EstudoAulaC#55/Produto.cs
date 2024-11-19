using System.Globalization;

namespace Course {
    class Produto {
        public string Nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto() { }
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }
        public string nome {
            get { return Nome; }
            set {
                if (value != null && value.Length > 1) {
                    Nome = value;
                }
            }
        }
        
        
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
