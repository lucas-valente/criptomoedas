namespace criptomoedas {
    internal class Corretora {
        
        public int CodigoCorretora { get; set; }
        public string NomeCorretora { get; set; }        
        public List<Carteira> Carteiras;
                
        public Corretora(int codigoCorretora, string nomeCorretora) {
            CodigoCorretora = codigoCorretora;
            NomeCorretora = nomeCorretora;
            Carteiras = new List<Carteira>();
        }
          
        public void InsereCarteira(Carteira Addcarteira) {
            Carteiras.Add( new Carteira { Endereco = Addcarteira.Endereco } );
        }

        public void ImprimeCorretora() {
            Console.WriteLine("\nCorretora\nCodigo:" + CodigoCorretora + ", Nome:" + NomeCorretora + ", Total de carteiras: " + Carteiras.Count );
        }
    }
}
