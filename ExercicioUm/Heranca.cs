
namespace ExercicioUm.Heranca
{
    // Exemplo de herança, simplificada

    // Este código define três classes relacionadas ao pagamento. A classe base "Pagamento" contém um método "Pagar" 
    // que exibe uma mensagem indicando que o usuário está pagando. Duas classes derivadas, "PagamentoBoleto" e 
    // "PagamentoCartaoCredito", herdam de "Pagamento" e adicionam funcionalidades específicas para pagamentos 
    // com boleto e cartão de crédito, respectivamente. Cada uma dessas classes derivadas possui métodos específicos
    // ("PagamentoComBoleto" e "PagamentoComCartaoCredito") que chamam o método "Pagar" da classe base e, em seguida,
    // exibem mensagens adicionais específicas para cada tipo de pagamento.

    class Pagamento
    {
        public void Pagar()
        {
            Console.WriteLine("O usuario esta pagando...");
        }
    }

    class PagamentoBoleto : Pagamento
    {
        public void PagamentoComBoleto()
        {
            Pagar();
            Console.WriteLine("O usuario pagou - Boleto de numero: 123123");
        }
    }

    class PagamentoCartaoCredito : Pagamento
    {
        public void PagamentoComCartaoCredito()
        {
            Pagar();
            Console.WriteLine("O usuario pagou - Cartão de credito: 3842 2341 2343 2321");
        }
    }
}
