using Domain.Base;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Usuario : IAggregateRoot
    {
        public Usuario(int Id, string Nome, string Email, string Senha)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
            // this.CPF = cpf;
            // this.Endereco = endereco;

            ValidateEntity();
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        // public CPF CPF { get; private set; }
        // public Endereco Endereco { get; private set; }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O campo Nome é obrigatório");
            AssertionConcern.AssertArgumentNotEmpty(Email, "O campo Email é obrigatório");
        }
    }
}