namespace BancoPOO
{
    public class Cliente : Pessoa
    {
        public string Endereco { get; set; }

        public static Cliente CriarPreencherCliente()
        {
            Cliente clienteObj = new Cliente();
            clienteObj.Preencher();
            return clienteObj;
        }

        public override void Preencher()
        {
            Console.WriteLine("=-=-=-= Cadastro do cliente =-=-=-=");
            base.Preencher();
            Console.WriteLine("Digite o endereço: ");
            Endereco = Console.ReadLine();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }

        public override void Imprimir()
        {
            Console.WriteLine("=-=-=-= Dados do cliente =-=-=-=");
            base.Imprimir();
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}