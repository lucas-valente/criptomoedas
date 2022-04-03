using criptomoedas;

Moeda mmoedaBTC = new Moeda("BTC", "Bitcoin");
Moeda mmoedaETC = new Moeda("ETC", "Ethereum");
Moeda mmoedaLTC = new Moeda("LTC", "Litecoin");
Moeda mmoedaTTH = new Moeda("TTH", "Tether");

Carteira n1 = new Carteira("sd56bsdb456as65gf46a5s");
n1.itemcarteira.Add(new ItemCarteira(5));
n1.itemcarteira.Add(new ItemCarteira(10));
n1.itemcarteira.Add(new ItemCarteira(15));
n1.itemcarteira.Add(new ItemCarteira(20));

ParMoeda pparmoeda = new ParMoeda(1000, mmoedaBTC);

Carteira ccarteira = new Carteira("sd56bsdb456as65gf46a5s");

Cliente ccliente = new Cliente();

Corretora ccorretora = new Corretora(4546, "Corretora 'A'");

ItemCarteira iitemcarteira = new ItemCarteira(10);


ccliente.Nome = "José";


mmoedaBTC.ImprimeMoeda();
mmoedaETC.ImprimeMoeda();
mmoedaLTC.ImprimeMoeda();
mmoedaTTH.ImprimeMoeda();


ccliente.ImprimeCliente();
iitemcarteira.ImprimeItemCarteira();
ccarteira.ImprimeCarteira();
ccorretora.ImprimeCorretora();
pparmoeda.ImprimeParMoeda();

