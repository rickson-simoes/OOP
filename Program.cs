﻿namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 - Uso das classes, objetos, herança, atribuindo valor as apropriedades e as utilizando, métodos.
            //var pagamentoBoleto = new PagamentoBoletoTeste("12312312312399");
            //pagamentoBoleto.Vencimento = DateTime.Now;

            //var pagamentoCartao = new PagamentoCartaoCreditoTeste();
            //pagamentoCartao.Vencimento = DateTime.Now;
            //pagamentoCartao.NumeroCartao = "1234 1234 9832 0233";

            ////pagamentoCartao.Pagar();
            //pagamentoBoleto.Pagar();
            #endregion

            #region 2 - uso de virtual com ovveride - Polimorfismo
            //Papagaio papagaio = new Papagaio();
            //var bemTeVi = new BemTeVi();
            //papagaio.Som();
            //bemTeVi.Som();
            #endregion

            #region 3 - Propriedades

            #endregion

        }
    }





    class PagamentoTeste
    {
        public DateTime Vencimento;

        public virtual void Pagar()
        {
            Console.WriteLine("O usuario esta pagando");
        }
    }

    class PagamentoBoletoTeste : PagamentoTeste
    {
        public string NumeroBoleto;

        public PagamentoBoletoTeste(string numeroBoleto)
        {
            NumeroBoleto = numeroBoleto;
        }

        public override void Pagar()
        {
            base.Pagar();

            Console.WriteLine("O usuario pagou - Boleto");
        }
    }

    class PagamentoCartaoCreditoTeste : PagamentoTeste
    {
        public string NumeroCartao;

        public override void Pagar()
        {
            base.Pagar();

            Console.WriteLine("O usuario pagou - Cartao Credito");
        }
    }

    public class Passaros
    {
       public virtual void Som()
        {
            Console.WriteLine("O som do animal é: ");
        }
    }

    public class Papagaio : Passaros
    {
        public override void Som()
        {
            base.Som();
            Console.WriteLine("Bom dia safado");
        }
    }

    public class BemTeVi : Passaros
    {
        public override void Som()
        {
            //base.Som();
            Console.WriteLine("Bem te vi");
        }

    }
}
