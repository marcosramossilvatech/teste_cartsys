namespace Cartsys.Domain.Entities
{
    public class Pessoa : Entity
    {
        public Pessoa(string nome, string cPF, string cEP, string logradouro, string telefone, string bairro, string cidade, string uF, string email, string senha, string confirmacaosenha)
        {
            Nome = nome;
            CPF = cPF;
            CEP = cEP;
            Logradouro = logradouro;
            Telefone = telefone;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            Email = email;
            Senha = senha;
            ConfimacaoSenha = confirmacaosenha;
        }

        public Pessoa() { }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string ConfimacaoSenha { get; set; } = string.Empty;
        
    }
}
