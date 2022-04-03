namespace criptomoedas {
    internal class ItemCarteira {

        public Moeda moeda { get; set; }
        public double Quantidade { get; set; }

        public ItemCarteira() { }

        public ItemCarteira(double quantidade) {
            Quantidade = quantidade;
        }

        public void ObtemCotacaoMoeda() {
            Quantidade += 1000;
        }

        public void ImprimeItemCarteira() {
            ObtemCotacaoMoeda();
            Console.WriteLine("Quantidade: {0}", this.Quantidade);
        }

       /* override public string ToString() {
            ObtemCotacaoMoeda();
            return "Quantidade: " + this.Quantidade;
        }*/
       
    }
}
