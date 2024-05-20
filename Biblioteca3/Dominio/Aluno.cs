namespace Dominio
{
    public class Aluno
    {
        private string matricula;
        private string nome;
        private string email;
        private string telefone;

        public Aluno(string matricula, string nome, string email, string telefone)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}