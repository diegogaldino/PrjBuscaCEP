namespace PrjBuscaCEP.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

    }
}