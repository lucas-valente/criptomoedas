namespace criptomoedas {
    internal class ParMoeda {
        
        public Moeda Moeda { get; set; }
        public double Valor { get; set; }
        
        public ParMoeda() { }
        
        public ParMoeda(double valor, Moeda moeda) {
            this.Valor = valor;
            this.Moeda = moeda;
        }
        
        public void ImprimeParMoeda() {
            Console.WriteLine("Imprime moeda base:'{0}', e moeda cotacao:'{1}'", this.Valor, this.Moeda.Nome);
        }

       /* override public string ToString() { 
            return "Imprime moeda base: " + this.Valor + ", e moeda cotacao: " + this.Moeda.Nome;
        }*/ 

    }
}
