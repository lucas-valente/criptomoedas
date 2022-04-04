using System.Collections.Generic;

namespace criptomoedas {
    internal class Carteira {
        
        public string Endereco { get; set; }
        public Cliente cliente { get; set; }
        public List<ItemCarteira> itemcarteira = new List<ItemCarteira>();
        
        public Carteira() { }

        public Carteira(string endereco, Cliente clienteadd) {
            Endereco = endereco;
            cliente = clienteadd;
        }

        public void InsereItemCarteira(double quantidade, Moeda moeda, ParMoeda addparmoeda) {
            itemcarteira.Add(new ItemCarteira { Quantidade = quantidade,Cmoeda = moeda, parMoeda = addparmoeda });
        }
        
               
        public void ImprimeCarteira() { 
            Console.WriteLine("\nCarteira\nEndereco carteira: {0}, Itens na carteira: {1}", Endereco, itemcarteira.Count);
        }

        public void ItemsCarteira() {
            foreach (ItemCarteira carteira in itemcarteira)
                Console.WriteLine("Cod: " + carteira.Cmoeda.Codigo + 
                    ", Nome: " + carteira.Cmoeda.Nome + 
                    ", Quantidade: "+ carteira.Quantidade + 
                    ", Valor: " + (carteira.parMoeda.Valor * carteira.Quantidade).ToString("F2") );
        }
    }
}
