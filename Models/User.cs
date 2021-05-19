using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSeed.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

    }

    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Nome).NotEmpty().WithMessage("Informe um nome válido!").Length(60);
            RuleFor(u => u.Email).NotEmpty().WithMessage("Informe um email válido!").EmailAddress().WithMessage("Informe um email válido!");
        }
    }
}
