using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CityValidation : AbstractValidator<City>
    {
        public CityValidation()
        {
            RuleFor(x => x.CityName).NotEmpty().WithMessage("Boş bırakılmaz.");
            RuleFor(x => x.CityName).MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz.");
            RuleFor(x => x.CityName).MaximumLength(20).WithMessage("En fazla 20 karakter girebilirsiniz.");
        }
    }
}
