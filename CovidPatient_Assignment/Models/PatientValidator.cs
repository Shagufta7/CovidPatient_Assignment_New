using FluentValidation;
namespace CovidPatient_Assignment.Models
{
    public class PatientValidator : AbstractValidator<Patient>
    {
        public PatientValidator()
        {
            RuleFor(expression: model => model.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(expression: model => model.PassportNumber).NotEmpty().WithMessage("Passport Number is required");
            RuleFor(expression: model => model.Emirates_ID).NotEmpty().WithMessage("Emirates ID is required");
            RuleFor(expression: model => model.Emirate).NotEmpty().WithMessage("Emirate is required");
            RuleFor(expression: model => model.Address).NotEmpty().WithMessage("Address is required");
            RuleFor(expression: model => model.FirstDose).NotEmpty().WithMessage("FirstDose is required");
            RuleFor(expression: model => model.SecondDose).NotEmpty().WithMessage("SecondDose is required");
            RuleFor(expression: model => model.ThirdDose).NotEmpty().WithMessage("ThirdDose is required");
            RuleFor(expression: model => model.ForthDose).NotEmpty().WithMessage("ForthDose is required");
            RuleFor(expression: model => model.RecordCreatedOn).NotEmpty().WithMessage("RecordCreatedOn is required");
        }
    }
}
