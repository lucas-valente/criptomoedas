namespace criptomoedas {
    internal class ParMoeda {

        public Moeda moedaBase { get; set; }
        public Moeda moedaCotacao { get; set; }
        public double Valor { get; set; }

        public ParMoeda() { }

        public ParMoeda(double valor, Moeda moeda, Moeda moedacotacao) {
            Valor = valor;
            moedaBase = moeda;
            moedaCotacao = moedacotacao;
        }

        public void ImprimeParMoeda() {
            Console.WriteLine("Vender: " + moedaBase.Codigo + ", Comprar: " + moedaCotacao.Codigo + ", Cotação: " + Valor);
        }

    }
}
