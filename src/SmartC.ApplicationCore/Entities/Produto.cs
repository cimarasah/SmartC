namespace SmartC.ApplicationCore.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public int IdItemClinica { get; set; }
        public virtual ItemClinica ItemClinica { get; set; }
        public virtual Estoque Estoque { get; set; }

    }
}