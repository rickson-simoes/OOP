
namespace ExercicioUm.Heranca
{
    class Pagamento
    {
        public DateTime Vencimento;

        public Pagamento(DateTime vencimento)
        {
            Vencimento = vencimento;
        }

        public virtual void Pagar()
        {
            Console.WriteLine($"O usuario esta pagando em: {Vencimento}");
        }
    }

    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto;

        public PagamentoBoleto(string numeroBoleto, DateTime vencimento) : base(vencimento)
        {
            NumeroBoleto = numeroBoleto;
        }

        public override void Pagar()
        {
            base.Pagar();
            Console.WriteLine($"O usuario pagou - Boleto de numero: {NumeroBoleto}");
        }
    }

    class PagamentoCartaoCredito : Pagamento
    {
        public string NumeroCartao;

        public PagamentoCartaoCredito(string numeroCartao, DateTime vencimento) : base(vencimento)
        {
            NumeroCartao = numeroCartao;
        }

        public override void Pagar()
        {
            base.Pagar();

            Console.WriteLine($"O usuario pagou - Cartao Credito de numero {NumeroCartao}");
        }
    }
}
