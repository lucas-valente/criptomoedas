﻿namespace criptomoedas {
    internal class ItemCarteira {

        public Moeda Cmoeda { get; set; }
        public double Quantidade { get; set; }

        public ParMoeda parMoeda { get; set; }

        public ItemCarteira() { }

        public ItemCarteira(double quantidade, Moeda criptomoeda) : this() {
            Quantidade = quantidade;
            Cmoeda = criptomoeda;
        }

        public ItemCarteira(double quantidade, Moeda criptomoeda, ParMoeda parmoeda) : this(quantidade,criptomoeda) {
            parMoeda = parmoeda;
        }

        public void ObtemCotacaoMoeda(Moeda moeda) {
            Quantidade += 12 ;
        }
        
        public void ImprimeItemCarteira() {
            ObtemCotacaoMoeda(Cmoeda);
            Console.WriteLine("Quantidade: {0}", this.Quantidade);
        }
               
    }
}
