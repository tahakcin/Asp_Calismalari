using FluentValidation;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace ornek.Models.Validators
{
	public class ClientValidator : AbstractValidator<Client>	
	{
        public ClientValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email boş olamaz!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen doğru bir email adresi giriniz.");
            RuleFor(x => x.ClientName).NotEmpty().WithMessage("Lütfen client name'i giriniz.");
            RuleFor(x => x.ClientName).NotNull().WithMessage("Client name boş olamaz!");
            RuleFor(x => x.ClientName).MaximumLength(100).WithMessage("Lütfen client name'i 100 karakterden fazla girmeyiniz.");
        }
    }
}
