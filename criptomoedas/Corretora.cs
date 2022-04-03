namespace criptomoedas {
    internal class Corretora {
        
        public int CodigoCorretora { get; set; }
        public string NomeCorretora { get; set; }
        
        public List<Carteira> Carteiras;
        
        public Corretora() { }
        
        public Corretora(int codigoCorretora, string nomeCorretora) {
            this.CodigoCorretora = codigoCorretora;
            this.NomeCorretora = nomeCorretora;
            this.Carteiras = new List<Carteira>();
        }
        
        public void ImprimeCorretora() {
            Console.WriteLine("Imprime codigo corretora {0}, {1}", this.CodigoCorretora, NomeCorretora);
        }
        
        public void InsereCarteira() {

        }

    }
}
