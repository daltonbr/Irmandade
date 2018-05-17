namespace Irmandade.Model
{
    public class Pessoa
    {
        public string CPF { get; set; }
        public string RG { get; set; }
        public string RGEmissor { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public string InicioDasAtividades { get; set; }
        public string Observacoes { get; set; }
        public string Email { get; set; }
        public int DisponivelSegunda { get; set; }
        public int DisponivelTerca { get; set; }
        public int DisponivelQuarta { get; set; }
        public int DisponivelQuinta { get; set; }
        public int DisponivelSexta { get; set; }
    }
}
