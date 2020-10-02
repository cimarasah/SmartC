namespace SmartC.ApplicationCore.Entities
{
    public class ItemPacote
    {
        public int Id { get; set; }
        public int IdServico { get; set; }
        public Servico Servico { get; set; }
        public int IdPacote { get; set; }
        public Pacote Pacote { get; set; }
    }
}