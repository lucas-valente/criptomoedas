using System.Collections.Generic;

namespace criptomoedas {
    class Program {
        static void Main(string[] args) {

            //Insere as Criptomoedas
            Moeda mmoedaBTC = new Moeda("BTC", "Bitcoin");
            Moeda mmoedaETC = new Moeda("ETC", "Ethereum");
            Moeda mmoedaLTC = new Moeda("LTC", "Litecoin");

            //Insere cliente
            Cliente ccliente = new Cliente(1834,"Lucas Ferreira Valente","valentelucas85@gmail.com","(41)995071014", "e10adc3949ba59abbe56e057f20f883e");

            //Insere as Moedas de conversão
            Moeda mmoedaUSD = new Moeda("USD", "Dolar Americano");

            //Recebe os valores de cotação e as moedas para cotação
            ParMoeda pparmoedaBTC = new ParMoeda(45979.51, mmoedaBTC,mmoedaUSD);
            ParMoeda pparmoedaETC = new ParMoeda(3465.66, mmoedaETC, mmoedaUSD);
            ParMoeda pparmoedaLTC = new ParMoeda(124.58, mmoedaLTC, mmoedaUSD);

            //Insere os atributos da corretora
            Corretora ccorretora = new Corretora(1, "Bit New");

            //Insere os itens na carteira
            Carteira ccarteira = new Carteira("e10adc3949ba59abbe56e057f20f883e", ccliente);
            ccarteira.InsereItemCarteira(2.5, mmoedaBTC,pparmoedaBTC);
            ccarteira.InsereItemCarteira(1.65, mmoedaETC,pparmoedaETC);
            ccarteira.InsereItemCarteira(0.55, mmoedaLTC,pparmoedaLTC);

            //Cria uma nova carteira
            ccorretora.InsereCarteira(ccarteira);


            
            //Imprime a cotação do par moeda
            Console.WriteLine("Pares de Moedas");
            pparmoedaBTC.ImprimeParMoeda();
            pparmoedaETC.ImprimeParMoeda();
            pparmoedaLTC.ImprimeParMoeda();

            //Imprime o codigo, nome e quantidades de intens da corretora
            ccorretora.ImprimeCorretora();
            
            //Impreime o nome da carteira e a quantidade de itens
            ccarteira.ImprimeCarteira();

            //Imprime o cliente
            Console.WriteLine("\nCliente");
            ccliente.ImprimeCliente();
            

            //Imprime os itens da carteira
            Console.WriteLine("\nItens na carteira");
            ccarteira.ItemsCarteira();

            ccarteira.Deposita(100, mmoedaBTC);
            ccarteira.Deposita(10, mmoedaETC);
            ccarteira.Deposita(100, mmoedaLTC);


            Console.WriteLine("\nItens na Carteira Atualizados após Deposito");
            ccarteira.ItemsCarteira();

            ccarteira.Saca(50, mmoedaBTC);
            ccarteira.Saca(0.34, mmoedaETC);
            ccarteira.Saca(30, mmoedaLTC);

            Console.WriteLine("\nItens na Carteira Atualizados após Saque");
            ccarteira.ItemsCarteira();
        }
    }
}