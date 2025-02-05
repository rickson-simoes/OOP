using ExercicioUm.Heranca;
using ExercicioDois.Polimorfismo;

namespace OOP
{
    using System;

    internal class Program
    {
        static void Main()
        {
            #region Inicio: Uso de uma classe com propriedades privadas
            //// Cria uma instância de Pagamento com vencimento e valor
            //// ======================================================================================

            //var pagamento = new Pagamento("DESCRIÇÃO FEITA NA HORA DO PAGAMENTO DE 50 REAIS", 50);
            //pagamento.MostrarDetalhes();
            //pagamento.Pagar();
            #endregion

            #region Exercicio 1 Herança: Uso de heranças
            //// NOTA.: estou utilizando "ExercicioUm.Heranca" para evitar erro de ambiguidade
            //// entre o nome parecido de classes do exercicio 1 com o 2.
            //// ======================================================================================

            //var boleto = new ExercicioUm.Heranca.PagamentoBoleto();
            //var cartaoCredito = new ExercicioUm.Heranca.PagamentoCartaoCredito();
            //boleto.PagamentoComBoleto();
            //Console.WriteLine("==========");
            //cartaoCredito.PagamentoComCartaoCredito();
            #endregion

            #region Exercicio 2 Polimorfismo
            //// Primeiro Exemplo
            //// ======================================================================================

            //var papagaio = new Papagaio();
            //var bemTeVi = new BemTeVi();
            //papagaio.Som();
            //Console.WriteLine("==========");
            //bemTeVi.Som();


            //// Segundo Exemplo:
            //// NOTA.: estou utilizando "ExercicioDois.Polimorfismo" para evitar erro de ambiguidade
            //// entre os nomes parecidos de classes do exercicio 1 com o 2.
            //// ======================================================================================

            //var pagamentoBoleto = new ExercicioDois.Polimorfismo.PagamentoBoleto("12312392399229999", DateTime.Now);
            //var pagamentoCartao = new ExercicioDois.Polimorfismo.PagamentoCartaoCredito("1234 1234 9834 2312", DateTime.Now);
            //pagamentoBoleto.Pagar();
            //Console.WriteLine("==========");
            //pagamentoCartao.Pagar();
            #endregion

        }
    }

    class Pagamento
    {
        private string? _descricao;
        public string? Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                // Definindo a descricao - Descricao feita na hora da instancia:

                Console.WriteLine("1 - AQUI É O QUE ESTÁ DENTRO DE VALUE, NESSE CASO, O QUE O USUARIO ESCREVEU NO PARAMETRO DA INSTANCIA");
                Console.WriteLine(value);
                // Logo acima, no "value" é o texto recebido na hora da instancia


                // aqui eu faço a alteracao para todo tipo de espaço na frase obter o underline: "_"
                // Com isso todo valor dentro de Descricao (que é a propriedade principal de dentro desse get set) vai receber
                // underline no lugar dos espaços.
                _descricao = value.Replace(" ", "_");

                Console.WriteLine("2 - AQUI É O QUE ESTÁ DEPOIS DE VALUE RECEBER UMA ALTERACAO");
                Console.WriteLine(_descricao);

                // Por qual razão isso foi feito?
                // Apenas para mostrar que podemos alterar um valor no momento que passamos valores nos parametros, 
                // evitando o uso de métodos
            }
        }


        private int _valor;
        public int Valor
        {
            // aqui não faço absolutamente nada com value, apenas faço com que um valor privado "_valor" receba dados de uma
            // classe instanciada com uma propriedade publica de mesmo tipo, nesse caso, "int".
            get { return _valor; }
            private set { _valor = value; }
        }

        // Metodo construtor para receber a descricao e o valor
        public Pagamento(string descricao, int valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine("==================MOSTRANDO DETALHES================");
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Descricao: {Descricao}");
        }

        public void Pagar()
        {
            Console.WriteLine("==================PAGAMENTO================");
            Console.WriteLine($"Pagamento de {Valor} com descricao: {Descricao}");
        }
    }

}
