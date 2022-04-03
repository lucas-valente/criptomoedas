namespace criptomoedas {
    internal class Moeda {
        
        public string Codigo { get; set; }
        public string Nome { get; set; }

        public Moeda(string codigo, string nome) {
            this.Codigo = codigo;
            this.Nome = nome;
        }
        
        public void ImprimeMoeda() {
        //    Console.WriteLine("Código da moeda:'{0}', Nome da moeda:'{1}'", this.Codigo, this.Nome);
        }

        override public string ToString() { 
            return "Código da moeda: " + this.Codigo + ", Nome da moeda: " + this.Nome ;
        }
    }
}
