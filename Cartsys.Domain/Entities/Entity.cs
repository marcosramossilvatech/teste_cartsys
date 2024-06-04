namespace Cartsys.Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
    }
}
