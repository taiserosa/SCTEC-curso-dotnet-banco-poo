namespace BancoPOO
{
    public class Transacao
    {
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }

        public Transacao(decimal valor, string tipo)
        {
            Valor = valor;
            Tipo = tipo;
            Data = DateTime.Now;
        }

        public void ImprimirTransacao()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Data: {Data}");
        }
    }
}