using ExercicioUm.Heranca;
using ExercicioDois.Polimorfismo;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 - Uso das classes, objetos, herança, atribuindo valor as apropriedades e as utilizando, métodos.
            //var pagamentoBoleto = new PagamentoBoleto("1231239999123123", DateTime.Now);
            //pagamentoBoleto.Pagar();

            //var pagamentoCartao = new PagamentoCartaoCredito("1234 5678 9345 2934", DateTime.Now);
            //pagamentoCartao.Pagar();
            #endregion

            #region 2 - uso de virtual com ovveride - Polimorfismo
            //Papagaio papagaio = new Papagaio();
            //var bemTeVi = new BemTeVi();
            //papagaio.Som();
            //bemTeVi.Som();
            #endregion

            #region 3 - (OBS.: PRECISO AJEITAR O ARQUIVO program.cs PARA MELHORAR A LEITURA)Propriedades - uso de prop privada, acessores (get, set), métodos 
            //var pagamento = new Pagamento(DateTime.Now);
            #endregion

        }
    }

    class Pagamento
    {
        public DateTime Vencimento;

        #region 1 - utilizando propriedade privada
        //public DateTime DataPagamento
        //{
        //    get { return _dataPagamento; }
        //    set { _dataPagamento = value; }
        //}
        #endregion

        #region 2 - utlizando get set 
        //public DateTime DataPagamento
        //{
        //    get {
        //        Console.WriteLine("Utilizando O GET");
        //        return _dataPagamento;
        //    }

        //    set {
        //        Console.WriteLine("Utilizando O SET");
        //        Console.WriteLine(value);
        //        _dataPagamento = value;
        //    }
        //}
        #endregion

        public Pagamento(DateTime vencimento)
        {
            Vencimento = vencimento;
        }

        //3 - Uso de Métodos nas classes - utilizando sobrecarga de métodos
        public virtual void Pagar(string numero)
        {
            Console.WriteLine("método pagar de dentro da classe pagamento");
            Console.WriteLine($"E este é o numero:{numero}");
        }
    }

    class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(DateTime banana) : base(banana)
        {

        }
        public override void Pagar(string numero)
        {
            base.Pagar(numero);
        }
    }
}
