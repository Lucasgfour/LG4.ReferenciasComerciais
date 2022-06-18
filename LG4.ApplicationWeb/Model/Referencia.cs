namespace LG4.ApplicationWeb.Model {
    public class Referencia {

        public Guid? id { get; set; }
        public string Nome { get; set; } = "";
        public string Empresa { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string Observacao { get; set; } = "";
        public string Email { get; set; } = "";
        public string Cidade { get; set; } = "";

        public Referencia() { }
    
    }
}
