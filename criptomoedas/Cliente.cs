namespace criptomoedas {
    internal class Cliente {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string PassHash { get; set; }

        public Cliente(int codigo, string nome, string email, string celular, string passHash) {
            Codigo = codigo;
            Nome = nome;
            Email = email;
            Celular = celular;
            PassHash = passHash;
        }

        public Cliente() {
            Codigo = 0;
            Nome = "Alan";
            Email = "alan@gmail";
            Celular = "95309999";
            PassHash = "654h6sr1h3s51h6s58dh56";
        }

        public void ImprimeCliente() {
            Console.WriteLine("Codigo: {0}, Nome: {1}, E-mail: {2}, Celular: {3}",
            Codigo, Nome, Email, Celular);
        }


    }
}
