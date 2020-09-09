using System.Collections.Generic;

namespace SmartC.ApplicationCore.Entities
{
    public class Clinica
    {
       
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public List<Profissional> Profissionais { get; set; }
        public List<ItemClinica> ItensClinica { get; set; }
    }
}