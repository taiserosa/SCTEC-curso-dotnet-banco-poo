namespace BancoPOO
{
    public class Conta
    {
        // atributos
        public int NumeroConta { get; set; }
        public Cliente Titular { get; set; }
        public Funcionario Gerente { get; set; }
        private decimal saldo;
        private List<Transacao> transacoes = new List<Transacao>();

        // construtores
        public Conta()
        {
            NumeroConta = new Random().Next();
        }
        public Conta(Cliente titular, Funcionario gerente)
        {
            NumeroConta = new Random().Next();
            Titular = titular;
            Gerente = gerente;
        }

        // métodos
        public void Depositar(decimal valor)
        {
            transacoes.Add(new Transacao (valor, "Depósito"));
            saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque!");
            }
            Transacao saque = new Transacao(valor, "Saque");
            transacoes.Add(saque);
            saldo -= valor;
        } 

        public decimal ObterSaldo()
        {
            return saldo;
        }
        public void ImprimirTransacoes()
        {
            Console.WriteLine("Transações: ");
            foreach(var transacao in transacoes)
            {
                transacao.ImprimirTransacao();
            }
        }

        public void ImprimirExtrato()
        {
            Titular.ImprimirCliente();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Saldo: {saldo}");
            ImprimirTransacoes();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}
