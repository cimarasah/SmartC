namespace SmartC.ApplicationCore.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int IdPerfil { get; set; }
        public Perfil Perfil { get; set; }


        public virtual Profissional Profissional { get; set; }
    }
}