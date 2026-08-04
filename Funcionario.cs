namespace BancoPOO
{
    public class Funcionario : Pessoa
    {
        public int Codigo { get; set; }
        public string Funcao { get; set; }

        public Funcionario()
        {
            Codigo = new Random().Next();
        }

        public static Funcionario CriarPreencherFuncionario()
        {
            Funcionario funcionarioObj = new Funcionario();
            funcionarioObj.Preencher();
            return funcionarioObj;
        }

        public override void Preencher()
        {
            Console.WriteLine("=-=-=-= Cadastro do Funcionário =-=-=-=");
            base.Preencher();
            Console.WriteLine("Digite a função: ");
            Funcao = Console.ReadLine();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Função: {Funcao}");
        }
    }
}