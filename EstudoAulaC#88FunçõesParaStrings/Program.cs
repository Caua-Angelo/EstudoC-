namespace EstudoAulaC_88FunçõesParaStrings {
    internal class Program {
        static void Main(string[] args) {
            
            string original = "abcde FGHIJ ABC abc DEFG ";
            
            string s1 = original.ToUpper();//coloca a string toda em maiusculo
            
            string s2 = original.ToLower();//coloca a string toda em minúsculo
            
            string s3 = original.Trim(); //apaga os espaços no string
            
            int n1 = original.IndexOf("bc");//pode colocar um valor ou uma string para procurar  na string
            
            int n2 = original.LastIndexOf("bc");//a ultima posição em que essa string aparece
            
            string s4 = original.Substring(3);//recorta uma string apartir da posição colocada
            
            string s5 = original.Substring(3, 5);//recorta uma quantidade de caracteres(5) da posição do primeiro argumento colocado(3)

            string s6 = original.Replace('a', 'x');//usado para substituir um caracter  ou uma string
            
            string s7 = original.Replace("abc", "xy");//usado para substituir um caracter  ou uma string

            bool b1 = String.IsNullOrEmpty(original);//verifica se  o boolean b1 é nulo ou se está vazio
            
            bool b2 = String.IsNullOrWhiteSpace(original);//verifica se uma string é nula ou se tem espaços em branco
            
            Console.WriteLine("Original: -" + original + "-");
            
            Console.WriteLine("ToUpper: -" + s1 + "-");
            
            Console.WriteLine("ToLower: -" + s2 + "-");
            
            Console.WriteLine("Trim: -" + s3 + "-");
            
            Console.WriteLine("IndexOf('bc'): " + n1);
            
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            
            Console.WriteLine("Substring(3): -" + s4 + "-");
            
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            
            Console.WriteLine("IsNullOrEmpty: " + b1);
            
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);


        }
    }
}
