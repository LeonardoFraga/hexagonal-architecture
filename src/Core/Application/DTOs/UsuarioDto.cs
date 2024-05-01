namespace Application.DTOs
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }

        //TODO: How to convert CPF and Endereco to DTOs?
        // public CPF CPF { get; set; }
        // public Endereco Endereco { get; set; }
    }
}