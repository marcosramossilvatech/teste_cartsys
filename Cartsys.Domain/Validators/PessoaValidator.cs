using Cartsys.Domain.Entities;
using FluentValidation;

namespace Cartsys.Domain.Validators
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .MaximumLength(50).WithMessage("O nome deve ter no máximo 50 caracteres.")
                .MinimumLength(3).WithMessage("O nome deve ter no mínimo 5 caracteres.");

            RuleFor(p => p.CPF)
                .NotEmpty().WithMessage("O CPF é obrigatório.")
                .Matches(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$").WithMessage("O CPF deve estar no formato 000.000.000-00.");

            RuleFor(p => p.Email)
                 .EmailAddress().When(p => !string.IsNullOrEmpty(p.Email)).WithMessage("O email é inválido.");

            RuleFor(p => p.Senha)
                   .NotEmpty().When(p => IsValidEmail(p.Email)).WithMessage("A senha é obrigatória.")
                   .MaximumLength(50).WithMessage("A senha deve ter no máximo 20 caracteres.");

            RuleFor(p => p.ConfimacaoSenha)                   
                   .NotEmpty().When(p => IsValidEmail(p.Email)).WithMessage("A confirmação da senha é obrigatória.")
                   .Equal(p => p.Senha).WithMessage("A confirmação da senha deve ser igual à senha.");

        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
