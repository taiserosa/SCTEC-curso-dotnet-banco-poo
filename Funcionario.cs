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

        public void PreencherFuncionario()
        {
            Console.WriteLine($"Informe o nome do funcionário: ");
            Nome = Console.ReadLine();

            Console.WriteLine($"Informe o CPF do funcionário: ");
            Cpf = Console.ReadLine();
            while (!ValidarCpf(Cpf))
            {
                Console.WriteLine("CPF inválido! Digite novamente!");
                Cpf = Console.ReadLine();
            }

            Console.WriteLine($"Informe o telefone do funcionário: ");
            Telefone = Console.ReadLine();

            Console.WriteLine($"Informe o e-mail do funcionário: ");
            Email = Console.ReadLine();
            while (!ValidarEmail())
            {
                Console.WriteLine("E-mail inválido! Digite novamente!");
                Email = Console.ReadLine();
            }

            Console.WriteLine($"Informe a função do funcionário: ");
            Funcao = Console.ReadLine();
        }

        public void ImprimirFuncionario()
        {
            Console.WriteLine("=-=-=-= Dados do funcionário =-=-=-=");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"E-mail: {Email}");
            Console.WriteLine($"Função: {Funcao}");
        }
    }
}