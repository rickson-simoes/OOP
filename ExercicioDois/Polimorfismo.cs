namespace ExercicioDois.Polimorfismo
{
    // Exemplo um, direto ao ponto sobre o que é o polimorfismo:
    public class Passaros
    {
        public virtual void Som()
        {
            Console.WriteLine("O animal é:");
        }
    }

    public class Papagaio : Passaros
    {
        public override void Som()
        {
            base.Som();
            Console.WriteLine("Papagaio!");
            Console.WriteLine("Disse: Bom dia safado");
        }
    }

    public class BemTeVi : Passaros
    {
        public override void Som()
        {
            base.Som();
            Console.WriteLine("BemTeVi");
            Console.WriteLine("Disse: Bem te vi");
        }
    }

    // Exemplo dois, um pouco mais elaborado sobre Heranças + Polimorfismo com construtor e explicação:
    #region Explicando de forma mais detalhada o que acontece aqui
    // As classes "PagamentoCartaoCredito" e "PagamentoBoleto" herdam da classe base "Pagamento".

    // A classe base "Pagamento" possui um construtor que aceita um parâmetro "DateTime vencimento"
    // e um método "Pagar" que pode ser sobrescrito nas classes derivadas, pois é declarado com a palavra-chave "virtual".

    // As classes derivadas "PagamentoCartaoCredito" e "PagamentoBoleto" possuem seus próprios construtores,
    // que aceitam parâmetros adicionais específicos a cada classe. Por exemplo, a classe "PagamentoBoleto"
    // tem a propriedade "numeroBoleto", enquanto a classe "PagamentoCartaoCredito" tem a propriedade "numeroCartao".

    // Nos construtores das classes derivadas, o parâmetro "vencimento" é passado para o construtor da classe base "Pagamento"
    // usando a palavra-chave "base". Além disso, os métodos "Pagar" são sobrescritos em ambas as classes derivadas
    // para fornecer uma implementação específica para cada tipo de pagamento.
    #endregion
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
