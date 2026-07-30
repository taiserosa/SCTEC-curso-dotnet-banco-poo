namespace BancoPOO
{
    public class Cliente : Pessoa
    {
        public string Endereco { get; set; }

        public bool ValidaCpf()
        {
            return true;
        }

        public void PreencherCliente()
        {
            Console.WriteLine($"Informe o nome do cliente: ");
            Nome = Console.ReadLine();

            Console.WriteLine($"Informe o CPF do cliente: ");
            Cpf = Console.ReadLine();
            while (!ValidaCpf())
            {
                Console.WriteLine("CPF inválido! Digite novamente!");
                Cpf = Console.ReadLine();
            }

            Console.WriteLine($"Informe o endereço do cliente: ");
            Endereco = Console.ReadLine();

            Console.WriteLine($"Informe o telefone do cliente: ");
            Telefone = Console.ReadLine();

            Console.WriteLine($"Informe o e-mail do cliente: ");
            Email = Console.ReadLine();
            while (!ValidarEmail())
            {
                Console.WriteLine("E-mail inválido! Digite novamente!");
                Email = Console.ReadLine();
            }

        }

        public void ImprimirCliente()
        {
            Console.WriteLine("=-=-=-= Dados do cliente =-=-=-=");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"E-mail: {Email}");
        }
    }
}