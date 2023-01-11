using FluentValidation;
using SquadManager.Models;

namespace SquadManager.Validator
{
	public class UserValidator : AbstractValidator<UserViewModel>
	{
		public UserValidator()
		{
			RuleFor(user => user.Email).NotNull().WithMessage("E-mail vazio");
			RuleFor(user => user.Email).EmailAddress().WithMessage("E-mail invalido");
			RuleFor(user => user.Username).NotNull().WithMessage("Username vazio");
			RuleFor(user => user.Password).NotNull().WithMessage("Senha vazio");
		}
	}
}
