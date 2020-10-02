using SmartC.ApplicationCore.Enuns;

namespace SmartC.ApplicationCore.Entities
{
    public class ServicoProfissional
    {
        public int Id { get; set; }
        public int IdServico { get; set; }
        public Servico Servico { get; set; }
        public int IdProfissional { get; set; }
        public Profissional Profissional { get; set; }
        public double Valor_Base { get; set; }
        public FormaCustoEnum FormaCusto { get; set; }
    }
}