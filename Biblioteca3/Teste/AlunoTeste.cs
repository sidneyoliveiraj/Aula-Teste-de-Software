using Bogus;
using Dominio;
using ExpectedObjects;

namespace Teste
{
    public class AlunoTeste
    {
        // atributos
        string _matricula;
        string _nome;
        string _email;
        string _telefone;

        //método construtor
        public AlunoTeste()
        {
            Faker faker = new Faker();

            string seq = faker.Random.Int(1000, 2000).ToString();  //sequencia
            string ano = faker.Random.Int(2020, 2024).ToString();
            string sem = faker.Random.Int(1, 2).ToString();    //semestre
            


            _matricula = seq+"-"+ano+"-"+sem;   // _matricula = $"{seq}-{ano}-{sem}";
            _nome = faker.Person.FullName;
            _email = faker.Person.Email;
            _telefone = faker.Person.Phone;
        }







        [Fact]
        public void CriarObjetoAluno()
        {
            var alunoEsperado = new { 
                Matricula = _matricula,
                Nome = _nome,
                Email = _email,
                Telefone = _telefone
            };

            Aluno aluno = new Aluno(_matricula, _nome, _email, _telefone);

            alunoEsperado.ToExpectedObject().ShouldMatch(aluno);
        }
    }
}