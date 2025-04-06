using FluentValidation;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace ornek.Models.Validators
{
	public class UserValidator : AbstractValidator<User>
	{
		public UserValidator() 
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter a user name.").MaximumLength(100).WithMessage("Name must include at most 100 characters");
			RuleFor(x => x.LastName).NotEmpty().WithMessage("Please enter a last name.");
			RuleFor(x => x.ID).NotEmpty().WithMessage("Please enter a user id.");
			RuleFor(x => x.Phone).NotEmpty().WithMessage("Please enter a phone number.");
			RuleFor(x => x.Phone).Matches(@"^[(]\d{3}[)]\d{7}").WithMessage("Phone number must be in the correct format.");
		}
	}
}
