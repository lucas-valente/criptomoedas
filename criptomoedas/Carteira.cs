using System.Collections.Generic;

namespace criptomoedas {
    internal class Carteira {
        public string Endereco { get; set; }

        public List<ItemCarteira> itemcarteira;

        public Carteira() { }

        public Carteira(string endereco) {
            this.Endereco = endereco;
            this.itemcarteira = new List<ItemCarteira>();
        }

        public void InsereItemCarteira() {

        }

        public void ImprimeCarteira() {
            Console.WriteLine("Endereco item carteira:{0}, Itens na carteira:{1}", this.Endereco, this.itemcarteira);
        }

        public void Deposita() {

        }

        public void Saca() {

        }
               
    }
}
